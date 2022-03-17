using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PriceQuotationApp.Models
{
    class GreaterThan : ValidationAttribute
    {
        private readonly double val;
        public GreaterThan(double val)
        {
            this.val = val;
        }

        public override bool IsValid(object value)
        {
            if (value == null)
                return false;

            double dblValue = Convert.ToDouble(value);

            return dblValue > this.val;
        }
    }
    public class PriceQuotationModel
    {
        [Required(ErrorMessage = "Sub total field is required.")]
        [GreaterThan(0, ErrorMessage = "Sub total must be greater than 0.")]
        public decimal? SubTotal { get; set; }
        
        [Required(ErrorMessage = "Discount percent is required.")]
        [Range(0, 100, ErrorMessage = "Discount percent should from 0-100")]
        public decimal? DiscountPercent { get; set; }
        
        public decimal? GetDiscountAmount()
        {
            return SubTotal * (DiscountPercent/100);
        }
        public decimal? GetTotal()
        {
            return SubTotal - GetDiscountAmount();
        }
    }
}
