using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PriceQuoteTipCalc.Models
{
    public class TipCalculatorModel
    {
        //Makes the input required
        [Required(ErrorMessage = "Please enter meal cost amount")]
        //requires the input to be greater than 0
        [Range(1,int.MaxValue,ErrorMessage = "Please enter a meal cost greater than $0")]
        //property to store input value for meal cost
        public decimal? MealCost { get; set; }
        /// <summary>
        /// calculates the 15% tip
        /// </summary>
        /// <returns></returns>
        public decimal? CalculateTip15()
        {
            //assigns the meal cost * 15% to a variable called fifteen
            decimal? fifteen = MealCost * (decimal).15;
            //returns variable called 15
            return fifteen;

        }
        /// <summary>
        /// calculates a 20% tip
        /// </summary>
        /// <returns></returns>
        public decimal? CalculateTip20()
        {
            //assigns the meal cost * 20% to a variable called twenty

            decimal? twenty = MealCost * (decimal).2;
            //returns variable called twenty

            return twenty;

        }
        /// <summary>
        /// calculates the 25% tip
        /// </summary>
        /// <returns></returns>
        public decimal? CalculateTip25()
        {
            //assigns the meal cost * 25% to a variable called twentyFive

            decimal? twentyFive = MealCost * (decimal).25;
            //returns variable called twentyFive

            return twentyFive;

        }
    }
}
