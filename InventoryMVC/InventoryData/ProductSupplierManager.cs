using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryData
{
    /// <summary>
    /// Repository of methods for working with Product and Supplier table in Inventory Database
    /// </summary>
    public class ProductSupplierManager
    {
        /// <summary>
        /// Gets all products
        /// </summary>
        /// <returns>List of products</returns>
        public static List<Product> GetProducts()
        {
            InventoryContext db = new InventoryContext();
            return db.Products.ToList();
        }

        /// <summary>
        /// Gets all suppliers
        /// </summary>
        /// <returns>List of suppliers</returns>
        public static List<Supplier> GetSupplier()
        {
            InventoryContext db = new InventoryContext();
            return db.Suppliers.ToList();
        }
    }
}
