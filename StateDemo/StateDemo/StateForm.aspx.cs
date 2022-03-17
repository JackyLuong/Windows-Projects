using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateDemo
{
    public partial class StateForm : System.Web.UI.Page
    {
        int counter = 0; // variables are not added to the view state automatically
        protected void Page_Load(object sender, EventArgs e) // page refreshes each time the button is clicked
        {
            if (Session["counter"] != null) // if defined
            {
                counter = (int)Session["counter"];
            }
            lblCount.Text = counter.ToString();
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            counter++;

            // add updated value to view state
            Session["counter"] = counter;

            lblCount.Text = counter.ToString();
        }

        protected void btnGo_Click(object sender, EventArgs e)
        {

        }
    }
}