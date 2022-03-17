using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryMVC.Models
{
    public class ProductSupplierViewModel
    {
        [Display(Name = "Product Name")]
        public string ProdName { get; set; }

        [Display(Name = "Supplier Name")]
        public string SupName { get; set; }

        //Possible to make numeric properties with type string
        // only used to pass to the view
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}
