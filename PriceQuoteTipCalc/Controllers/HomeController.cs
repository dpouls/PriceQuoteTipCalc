using Microsoft.AspNetCore.Mvc;
using PriceQuoteTipCalc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriceQuoteTipCalc.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            //initial viewbag total value
            ViewBag.Total = 0;
            //initial viewbag discount amount value
            ViewBag.DiscountAmount = 0;
            //returns the view
            return View();
        }

        /// <summary>
        /// uses the pricequotemodel to get correct calculations after validating data
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Index(PriceQuoteModel model)
        {
            //checks modelstate to see if it should continue
            if (ModelState.IsValid)
            {
                //assigns discount amount to approprate viewbag variable
                ViewBag.DiscountAmount = model.CalculateDiscount();
                //assigns total amount to appropriate viewbag variable
                ViewBag.Total = model.CalculateTotal();
            }
            else
            {
                //resets the total to 0
                ViewBag.Total = 0;
                //resets the discount amount to 0
                ViewBag.DiscountAmount = 0;
            }
            //returns the view
            return View(model);
        }

        /// <summary>
        /// works like index() above, sets initial values and distinguishes it as a get request method
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult TipCalculator()
        {
            //set initial value
            ViewBag.Fifteen = 0;
            //set initial value
            ViewBag.Twenty = 0;
            //set initial value
            ViewBag.TwentyFive = 0;
            //returns the view
            return View();
        }
        /// <summary>
        /// post method, calculates tips and assigns them to viewbag variables
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult TipCalculator(TipCalculatorModel model)
        {
            //checks modelstate before continuing
            if (ModelState.IsValid)
            {
                //assigns fifteen to result of the calculatetip15() method in the model
                ViewBag.Fifteen = model.CalculateTip15();
                //assigns twenty to result of the calculatetip20() method in the model

                ViewBag.Twenty = model.CalculateTip20();
                //assigns twentyFive to result of the calculatetip25() method in the model

                ViewBag.TwentyFive = model.CalculateTip25();
            }
            else
            {
                //resets initial value
                ViewBag.Fifteen = 0;
                //resets initial value

                ViewBag.Twenty = 0;
                //resets initial value

                ViewBag.TwentyFive = 0;
            }
            //returns view
            return View(model);
        }

    }
}
