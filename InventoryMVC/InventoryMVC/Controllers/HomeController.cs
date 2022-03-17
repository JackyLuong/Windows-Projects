using InventoryData;
using InventoryMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace InventoryMVC.Controllers
{
    public class HomeController : Controller
    {
        //Display all products with supplier names
        public IActionResult Index()
        {
            List<Product> products = ProductSupplierManager.GetProducts();
            List<Supplier> suppliers = ProductSupplierManager.GetSupplier();
            List<ProductSupplierViewModel> combineList =
                (from prod in products
                 join sup in suppliers on prod.SupplierId equals sup.Id
                 orderby prod.Name
                 select new ProductSupplierViewModel
                 {
                     ProdName = prod.Name,
                     SupName = sup.Name,
                     Price = prod.Price,
                     Quantity = prod.Quantity
                 }).ToList();
            return View(combineList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
