using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace PriceQuoteTipCalc.Models
{
    public class PriceQuoteModel
    {
        //requires that the input has a value
        [Required(ErrorMessage = "Please enter a subtotal")]
        //requires the value to be greater than 0
        [Range(1,int.MaxValue, ErrorMessage ="Please enter a subtotal greater than 0")]
        //property to store the subtotal value
        public decimal? Subtotal { get; set; }
        //requires that the input has a value
        [Required(ErrorMessage = "Please enter a discount percent")]
        //requires that the value be between 1 and 100
        [Range(1, 100, ErrorMessage = "Please enter a discount percent between 0 and 100")]
        //property to store the discount percent
        public decimal? DiscountPercent { get; set; }
        
        /// <summary>
        /// Calculates the discount amount
        /// </summary>
        /// <returns></returns>
       public decimal? CalculateDiscount()
        {
            //assigns the discount amount calculation to a suitable variable
            decimal? discountAmount = Subtotal * (DiscountPercent / 100);
            //returns the calculated discount amount
            return discountAmount;
        }
        /// <summary>
        /// calculates the toal
        /// </summary>
        /// <returns></returns>
        public decimal? CalculateTotal()
        {
            //same as above to get the discount amount
            decimal? discountAmount = Subtotal * (DiscountPercent / 100);
            //subracts the discount amount from subtotal for total
            decimal? total = Subtotal - discountAmount;
            //returns the total
            return total;
        }
    }
}
