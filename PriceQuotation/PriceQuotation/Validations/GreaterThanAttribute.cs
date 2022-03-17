using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PriceQuotation.Validations
{
    public class GreaterThan : ValidationAttribute
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
}
