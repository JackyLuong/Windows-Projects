using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TempManager.Validation
{
    public class CurrentDateTimeAttribute : ValidationAttribute
    {
        private DateTime minDate;
        public CurrentDateTimeAttribute(string minDate)
        {
            this.minDate = Convert.ToDateTime(minDate);
        }
        public override bool IsValid(object value)
        {
            if (value == null)
                return false;
            DateTime dateTimeToValidate = (DateTime)value;
            if(dateTimeToValidate > minDate && dateTimeToValidate < DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
