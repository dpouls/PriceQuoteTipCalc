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
            ViewBag.Total = 0;
            ViewBag.DiscountAmount = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(PriceQuoteModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.DiscountAmount = model.CalculateDiscount();
                ViewBag.Total = model.CalculateTotal();
            }
            else
            {
                ViewBag.Total = 0;
                ViewBag.DiscountAmount = 0;
            }
            return View(model);
        }


        [HttpGet]
        public IActionResult TipCalculator()
        {
            ViewBag.Fifteen = 0;
            ViewBag.Twenty = 0;
            ViewBag.TwentyFive = 0;
            return View();
        }

        [HttpPost]
        public IActionResult TipCalculator(TipCalculatorModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Fifteen = model.CalculateTip15();
                ViewBag.Twenty = model.CalculateTip20();
                ViewBag.TwentyFive = model.CalculateTip25();
            }
            else
            {
                ViewBag.Fifteen = 0;
                ViewBag.Twenty = 0;
                ViewBag.TwentyFive = 0;
            }
            return View(model);
        }

    }
}
