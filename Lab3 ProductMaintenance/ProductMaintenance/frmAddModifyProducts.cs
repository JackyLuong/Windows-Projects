using ProductMaintenance.Models;
using System;
using System.Windows.Forms;

namespace ProductMaintenance
{
    public partial class frmAddModifyProducts : Form
    {
        public bool isAdd; // checks if the user wants to add or modify
        public Product prod; // empty product
        public frmAddModifyProducts()
        {
            InitializeComponent();
        }

        private void frmAddModifyProducts_Load(object sender, EventArgs e)
        {
            if(isAdd) // a new product is added to the database
            {
                prod = new Product(); // create new product
                txtProductCode.ReadOnly = false;
            }
            // product is selected to modify. Displays selected product's data to the input fields
            else if (prod != null)
            {
                //Display all the data from the selected product to its respective fields
                txtName.Text = prod.Name;
                txtProductCode.Text = prod.ProductCode;
                txtVersion.Text = prod.Version.ToString();
                dtpReleaseDate.Value = prod.ReleaseDate.Date;
                txtProductCode.ReadOnly = true;
            }
            else // prod returns null meaning that no product was selected to modify
            {
                MessageBox.Show("No product was selected to be modified", "No Product Found");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Minimun Release date that the product can be released
            //1968 is the year before the internet was invented
            DateTime minReleaseDate = new DateTime(1968, 12, 31);
            if (Validator.isPresent(txtName) &&
                Validator.isPresent(txtProductCode) &&
                Validator.isPresent(txtVersion) &&
                Validator.IsNonNegativeDecimal(txtVersion) &&
                Validator.IsDateInRange(dtpReleaseDate, minReleaseDate, DateTime.Now)
                )
            {
                // update/create product information
                prod.Name = txtName.Text;
                prod.ProductCode = txtProductCode.Text;
                prod.Version = Convert.ToDecimal(txtVersion.Text);
                prod.ReleaseDate = dtpReleaseDate.Value.Date;

                //Return back to Product Maintenance form
                this.DialogResult = DialogResult.OK;
            }
        }

        /*
         * Close the form and cancels the adding/modifying process
         */
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
