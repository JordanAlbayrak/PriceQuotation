using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using PriceQuotation.Models;


namespace FutureValue.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.FV = 0;
            ViewBag.DA = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(PriceQuotationModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FV = model.CalculatePriceQuotation();
                ViewBag.DA = model.CalculateDiscountAmount();
            }
            else
            {
                ViewBag.FV = 0;
                ViewBag.DA = 0;
            }
            return View(model);
        }

    }
}



