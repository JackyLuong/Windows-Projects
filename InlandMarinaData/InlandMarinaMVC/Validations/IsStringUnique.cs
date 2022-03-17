using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InlandMarinaMVC.Validations
{
    public static class IsStringUnique
    {
        /// <summary>
        /// Goes throught the list of string and compares each item to the given string value
        /// </summary>
        /// <param name="list">list of string value</param>
        /// <param name="value">given string to check</param>
        /// <returns>true if there are no simularities, false if string value exists in the list</returns>
        public static bool IsValid(List<string> list, string value)
        {
            int counter = 0;
            foreach (string item in list)
            {
                if (item == value)
                {
                    counter++;
                }
            }
            if (counter == 0)
                return true;
            else
                return false;
        }
    }
}
