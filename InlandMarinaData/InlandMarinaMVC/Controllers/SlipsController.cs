using InlandMarinaData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InlandMarinaMVC.Controllers
{
    public class SlipsController : Controller
    {
        // GET: SlipsController
        public ActionResult Index()
        {
            List<Slip> unleasedSlips = SlipManager.GetUnleasedSlips();
            return View(unleasedSlips);
        }
        [Authorize]
        public ActionResult customerSlips()
        {
            if (HttpContext.Session.GetInt32("CurrentCustomer") != null)
            {
                List<Slip> custSlips = SlipManager.GetUnleasedSlipsByCustId((int)HttpContext.Session.GetInt32("CurrentCustomer"));
                return View(custSlips);
            }
                
            return View("Login","Account");
        }
    }
}
