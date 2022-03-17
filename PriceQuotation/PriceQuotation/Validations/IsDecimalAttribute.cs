using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PriceQuotation.Validations
{
    public class IsDecimalAttribute : ValidationAttribute
    {
        public override bool IsDefaultAttribute()
        {
            return false;
        }
    }
}
