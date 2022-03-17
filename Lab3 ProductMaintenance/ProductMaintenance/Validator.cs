using System;
using System.Windows.Forms;

namespace ProductMaintenance
{
    /// <summary>
    /// Validates input fields before they are submitted
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Checks if the text box is empty
        /// </summary>
        /// <param name="txtBox"></param>
        /// <returns></returns>
        public static bool isPresent(TextBox txtBox)
        {
            bool isValid = true;
            if (txtBox.Text == "") // empty
            {
                isValid = false;
                MessageBox.Show(txtBox.Name + " is required");
                txtBox.Focus();
            }
            return isValid;
        }
        /// <summary>
        /// Validates if the textBox contains non-negative decimal value
        /// </summary>
        /// <param name="txtBox"></param>
        /// <returns></returns>
        public static bool IsNonNegativeDecimal(TextBox txtBox)
        {
            bool isValid = true;
            decimal result; // for try parse

            if (!decimal.TryParse(txtBox.Text, out result)) // TryParse returned false
            {
                isValid = false;
                MessageBox.Show(txtBox.Tag + " must be a number");
                txtBox.SelectAll();
                txtBox.Focus();
            }
            else
            {
                //True if the number is less than 0
                if (result < 0)
                {
                    isValid = false;
                    MessageBox.Show(txtBox.Tag + "must be a positive number");
                    txtBox.SelectAll();
                    txtBox.Focus();
                }
            }
            return isValid;
        }
        /// <summary>
        /// Validates if the textBox contains non-negative int value
        /// </summary>
        /// <param name="txtBox"></param>
        /// <returns></returns>
        public static bool IsNonNegativeInt(TextBox txtBox)
        {
            bool isValid = true;
            int result; // for try parse

            if (!int.TryParse(txtBox.Text, out result)) // TryParse returned false
            {
                isValid = false;
                MessageBox.Show(txtBox.Tag + " must be a number");
                txtBox.SelectAll();
                txtBox.Focus();
            }
            else
            {
                //True if the number is less than 0
                if (result < 0)
                {
                    isValid = false;
                    MessageBox.Show(txtBox.Tag + "must be a positive number");
                    txtBox.SelectAll();
                    txtBox.Focus();
                }
            }
            return isValid;
        }
        /// <summary>
        /// Validates if the textBox the Date value is in range
        /// </summary>
        /// <param name="txtBox"></param>
        /// <returns></returns>
        public static bool IsDateInRange(DateTimePicker dtp, DateTime min, DateTime max)
        {
            bool isValid = true;
            DateTime result = dtp.Value; // for try parse

            //True if the date is past the min date and before the max date
            if (result < min || result > max)
            {
                isValid = false;
                MessageBox.Show(dtp.Tag + "An invalid date was entered");
                dtp.Focus();
            }
            return isValid;
        }
    }
}
