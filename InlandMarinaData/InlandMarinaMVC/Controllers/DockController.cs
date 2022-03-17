using InlandMarinaData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InlandMarinaMVC.Controllers
{
    public class DockController : Controller
    {
        // GET: DockController
        public ActionResult Index()
        {
            List<Dock> docks = DockManager.GetDocks();
            return View(docks);
        }

        // GET: DockController/Details/5
        public ActionResult Details(int id)
        {
            List<Slip> slips = SlipManager.GetUnleasedSlipsByDocks(id);
            return View(slips);
        }
    }
}
