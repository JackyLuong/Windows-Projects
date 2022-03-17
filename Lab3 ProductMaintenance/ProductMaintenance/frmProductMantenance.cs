using ProductMaintenance.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProductMaintenance
{
    public partial class frmProductMaintenance : Form
    {
        public Product selectedProduct; // selected product that can be modified and deleted

        public frmProductMaintenance()
        {
            InitializeComponent();
        }

        /*
         * Display Products from the database when the form loads
         */
        private void frmProductMaintenance_Load(object sender, EventArgs e)
        {
            DisplayProducts();
        }

        /*
         * Take information from the second class to add the new product to the database and display it in the DataGridView
         */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddModifyProducts secondFrm = new frmAddModifyProducts(); // create add form object
            secondFrm.isAdd = true; // adding new product
            
            DialogResult result = secondFrm.ShowDialog(); // display add/modify form
            
            // add product information from the second form to the database and display it in this form
            if (result == DialogResult.OK)
            {
                try
                {
                    using (TechSupportContext db = new TechSupportContext())
                    {
                        db.Add(secondFrm.prod);
                        db.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error has occured when trying to add the product." + ex.Message, ex.GetType().ToString());
                }
                DisplayProducts();
            }
        }

        /*
         * Modify the selected product
         */
        private void btnModify_Click(object sender, EventArgs e)
        {
            getSelectedValue();
            frmAddModifyProducts secondFrm = new frmAddModifyProducts(); // create modify form object
           
            secondFrm.isAdd = false; // modifing an exisiting product
            secondFrm.prod = selectedProduct;
           
            DialogResult result = secondFrm.ShowDialog(); // display add/modify form
            
            // add product information from the second form to the database and display it in this form
            if (result == DialogResult.OK)
            {
                try
                {
                    using (TechSupportContext db = new TechSupportContext())
                    {
                        // get current product that is being modified
                        selectedProduct = db.Products.Find(secondFrm.prod.ProductCode);

                        //Update current product data
                        selectedProduct.ProductCode = secondFrm.prod.ProductCode;
                        selectedProduct.Name = secondFrm.prod.Name;
                        selectedProduct.Version = secondFrm.prod.Version;
                        selectedProduct.ReleaseDate = secondFrm.prod.ReleaseDate;
                        db.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error has occured when trying to modify current product" + ex.Message, ex.GetType().ToString());
                }
                DisplayProducts();
            }
        }
        
        /*
         * Delete the selected product from the database and updates the data grid view
         */
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //get selected product
            getSelectedValue();
            try
            {
                using (TechSupportContext db = new TechSupportContext())
                {
                    db.Remove(selectedProduct);
                    db.SaveChanges();
                }
                DisplayProducts();
            }
            catch (Exception ex) //write an exception message
            {
                MessageBox.Show("Error has occured when trying to delete the selected product" + ex.Message, ex.GetType().ToString());
            }
        }
        
        //Close the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*
         * Display data of each products from the database to the DataGridView
         */
        private void DisplayProducts()
        {
            try
            {
                // displays code, name, version and release data of each product in the database
                using (TechSupportContext db = new TechSupportContext())
                {
                    dgvProducts.DataSource = db.Products.Select(p => new { p.ProductCode, p.Name, p.Version, p.ReleaseDate }).ToList();
                }
                StyleDataGridView(dgvProducts);
            }
            catch (Exception ex) //write an exception message
            {
                MessageBox.Show("Error has occured when trying to Display Products" + ex.Message, ex.GetType().ToString());
            }
        }

        //Fits all the columns and fills the entire data grid view field
        private void StyleDataGridView(DataGridView dgv)
        {
            // Set your desired AutoSize Mode:
            //dgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Now that DataGridView has calculated it's Widths; we can now store each column Width values.
            //for (int i = 0; i <= dgv.Columns.Count - 1; i++)
            //{
            //    // Store Auto Sized Widths:
            //    int colw = dgv.Columns[i].Width;

            //    // Remove AutoSizing:
            //    dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            //    // Set Width to calculated AutoSize value:
            //    dgv.Columns[i].Width = colw;
            //}

            dgv.EnableHeadersVisualStyles = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // auto size the columns to fit all the cell's content
            dgv.Columns[dgv.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // last cell fills the empty space
        }
        
        //get selected product
        private void getSelectedValue()
        {
            try
            {
                using (TechSupportContext db = new TechSupportContext())
                {
                    if (dgvProducts.SelectedCells.Count > 0)
                    {
                        int selecedRowIndex = dgvProducts.SelectedCells[0].RowIndex; // get row index
                        DataGridViewRow selectedRow = dgvProducts.Rows[selecedRowIndex]; // get row from selected cell
                        
                        // get product data based on the product code specified in the row
                        selectedProduct = db.Products.Find(selectedRow.Cells["ProductCode"].Value);
                    }
                }
            }
            catch (Exception ex) //write an exception message
            {
                MessageBox.Show("Error has occured when trying to get current product" + ex.Message, ex.GetType().ToString());
            }
        }
    }
}
