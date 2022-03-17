using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RentalsData;
using RentalsMVC.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace RentalsMVC.Controllers
{
    public class RentalsController : Controller
    {
        // GET: RentalsController
        public ActionResult Index()
        {
            List<RentalProperty> rentals = RentalsManager.GetAll();
            List<RentalViewModel> viewModels = rentals.Select(r => new RentalViewModel { 
                Address = r.Address,
                City = r.City,
                Province = r.Province,
                Rent = r.Rent.ToString("c"),
                PropertyType= r.PropertyType.Style,
                Owner = r.Owner.Name
            }).ToList();
            return View(viewModels);
        }

        // GET: RentalsController/List
        [Authorize]
        public ActionResult List()
        {
            List<RentalProperty> rentals = null;
            //get id of the current owner
            int? ownerId = HttpContext.Session.GetInt32("CurrentOwner");
            if (ownerId == null) // owner logged in
                ownerId = 0;
            ViewBag.OwnerId = (int)ownerId;
            rentals = RentalsManager.GetPropertiesByOwner((int)ownerId);
            return View(rentals);
        }
        //if current user is Owner then display filtered properties by current owner id
        //otherwise display all
        // GET: RentalsController/Create
        [Authorize (Roles = "Owner")]
        public ActionResult Create()
        {
            //get id of the current owner
            int? ownerId = HttpContext.Session.GetInt32("CurrentOwner");
            if (ownerId == null) // owner logged in
                ownerId = 0;

            ViewBag.OwnerId = (int)ownerId;
            ViewBag.PropertyTypes = GetPropertyTypes(); // property types to populate drop down
            return View(new RentalProperty());
        }

        // POST: RentalsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RentalProperty rental)
        {
            try
            {
                RentalsManager.Add(rental);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }   

        // auxilliary method for Create 
        protected IEnumerable GetPropertyTypes()
        {
            // call property types manager to get key/value pairs for property types drop down list 
            var types = PropertyTypesManager.GetAllAsKeyValuePairs();
            // convert it to a form that drop down list can use, and add to the bag
            var styles = new SelectList(types, "Value", "Text");
            var list = styles.ToList(); // to be able to use Insert method
            list.Insert(0, new SelectListItem
            {
                Value = "0",
                Text = "All Styles"
            });
            return list;
        }
    }
}
