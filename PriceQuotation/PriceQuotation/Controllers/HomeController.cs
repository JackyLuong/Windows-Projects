using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PriceQuotation.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PriceQuotation.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index() // HttpGet
        {
            ViewBag.discountAmount = 0;
            ViewBag.total = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(PriceQuotationModel model) // HttpPost
        {
            if(ModelState.IsValid)
            {
                ViewBag.discountAmount = model.CaluclateDiscountAmount();
                ViewBag.total = model.CalculateTotal();
            }
            else
            {
                ViewBag.discountAmount = 0;
                ViewBag.total = 0;
            }

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
