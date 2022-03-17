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
    public class LeaseController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            List<Slip> unleasedSlips = SlipManager.GetUnleasedSlips();
            return View(unleasedSlips);
        }
        [Authorize]
        public ActionResult AddLease(int id)
        {
            if(HttpContext.Session.GetInt32("CurrentCustomer") != null)
            {
                //customer leases a new slip
                LeaseManager.AddLease(id, (int)HttpContext.Session.GetInt32("CurrentCustomer"));
                return RedirectToAction("customerSlips","Slips");
            }
            List<Slip> unleasedSlips = SlipManager.GetUnleasedSlips();
            return View(unleasedSlips);
        }
    }
}
