using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PayRollWebForm
{
    public partial class payRollWebForm : System.Web.UI.Page
    {
        const decimal FULL_WEEK = 30m;
        const decimal OT_RATE = 1.5m;
        protected void Page_Load(object sender, EventArgs e)
        {
            //UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Calculate_Click(object sender, EventArgs e)
        {
            decimal rate = Convert.ToDecimal(txtRate.Text);
            decimal hoursWorked = Convert.ToDecimal(txtHours.Text);
            decimal pay;
            if(hoursWorked > FULL_WEEK)
            {
                pay = (FULL_WEEK * rate) + ((hoursWorked - FULL_WEEK) * rate * OT_RATE);
            }
            else
            {
                pay = hoursWorked * rate;
            }
            lblPay.Text = pay.ToString("c");
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            txtHours.Text = "";
            txtRate.Text = "";
            lblPay.Text = "";
        }
    }
}