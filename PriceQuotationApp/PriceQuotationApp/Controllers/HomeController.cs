using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PriceQuotationApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PriceQuotationApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Discount = 0;
            ViewBag.Total = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(PriceQuotationModel model)
        {
            if (model.DiscountPercent == null || model.SubTotal == null || !ModelState.IsValid)
            {
                ViewBag.Discount = 0;
                ViewBag.Total = 0;
            } else
            {
                ViewBag.Discount = model.GetDiscountAmount();
                ViewBag.Total = model.GetTotal();
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
