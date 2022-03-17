using PriceQuotation.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PriceQuotation.Models
{
    public class PriceQuotationModel
    {
        [Required(ErrorMessage = "Please enter a discount percentage.")]
        [RegularExpression (@"^\d+(\.\d{1,2})?$", ErrorMessage = "Please enter a decimal value for subtotal.")]
        [GreaterThan (0,ErrorMessage = "Subtotal must be greater than 0")]
        public decimal? Subtotal { get; set; }
        
        [Required(ErrorMessage = "Please enter a discount percentage.")]
        [GreaterThan(0, ErrorMessage = "Subtotal must be greater than 0")]
        //[Range(1, 75, ErrorMessage = "Please enter a value that is between 1 and 75%")]
        public decimal? DiscountPercent { get; set; }

        /// <summary>
        /// Caclucaltes Discount amount
        /// </summary>
        /// <returns>Discount amount</returns>
        public decimal? CaluclateDiscountAmount()
        {
            decimal? disAmount = 0;

            disAmount = Subtotal * (DiscountPercent / 100);
            
            return disAmount;
        }

        /// <summary>
        /// Caluclate total
        /// </summary>
        /// <returns> subtotal - discount amount</returns>
        public decimal? CalculateTotal()
        {
            decimal? total = 0;

            total = Subtotal - (Subtotal * (DiscountPercent / 100));

            return total;
        }
    }
}
