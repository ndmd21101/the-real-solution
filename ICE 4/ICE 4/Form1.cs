using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Name: Nguyen Duc
//Date: 12th April, 2022
//Github: https://github.com/ndmd21101/the-real-solution/tree/master/ICE%204
//ICE 4
namespace ICE_4
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region GLOBAL VARS
        List<String> Size = new List<String>();
        List<String> Category = new List<String>();
        public static List<Product> Products = new List<Product>();
        Boolean DoSelectionChange = true;
        #endregion

        #region EVENT HANDLERS
        /// <summary>
        /// Main form loading commands
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            PopulateSize();
            PopulateCategory();
            cboSize.DataSource = Size;
            cboCategory.DataSource = Category;
            Products = Product.GetSampleProduct();
            DoSelectionChange = false;
            PopulateProductList();
            DoSelectionChange = true;
            
        }

     
        #endregion

        #region CUSTOM METHODS
        private void PopulateSize()
        {
            Size.Add("S");
            Size.Add("M");
            Size.Add("L");
            Size.Add("XL");
            Size.Add("2XL");
            Size.Add("3XL");
           
        }
        private void PopulateCategory()
        {
            Category.Add("Tops");
            Category.Add("Jackets");
            Category.Add("Shorts");
            Category.Add("Joggers");
        }

        private void SetDefaults()
        {
            lblPrimaryColor.BackColor = Color.Gray;
            lblSecondaryColor.BackColor = Color.Gray;
            txtName.Clear();
            cboCategory.SelectedIndex = 2;
            cboSize.SelectedIndex = -1;
            nudQuantity.Value = 0;
            
        }



        private void PopulateProductList()
        {
            this.dgvProducts.DataSource = null;
            this.dgvProducts.ClearSelection();
            this.dgvProducts.DataSource = Products;
            this.dgvProducts.ClearSelection();
        }
       

        private void PopulateProduct(Product t)
        {
            this.nudQuantity.Value = t.Quantity;
            this.txtName.Text = t.ProductName;
            this.cboCategory.SelectedItem = t.Category;
            this.cboSize.SelectedItem = t.Size;
            this.lblPrimaryColor.BackColor = t.PrimaryColor;
            this.lblSecondaryColor.BackColor = t.SecondaryColor;

        }
       


        #endregion






       

       
        private void btnSave_Click_1(object sender, EventArgs e)
        {  
            Product t = new Product();
            t.Category = this.cboCategory.SelectedItem.ToString();
            t.Size = this.cboCategory.SelectedItem.ToString();
            t.Quantity = decimal.ToInt32(this.nudQuantity.Value);
            t.ProductName = this.txtName.Text.Trim();
            t.PrimaryColor = this.lblPrimaryColor.BackColor;
            t.SecondaryColor = this.lblSecondaryColor.BackColor;
            Products.Add(t);
            PopulateProductList();
            SetDefaults();
        }

        private void lblPrimaryColor_Click(object sender, EventArgs e)
        {

            colorDialog2.ShowDialog();
            lblPrimaryColor.BackColor = colorDialog2.Color;
        }

        private void lblSecondaryColor_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            lblSecondaryColor.BackColor = colorDialog2.Color;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout newForm = new frmAbout();
            newForm.ShowDialog();
            newForm.Dispose();
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                int selectedProduct = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells[0].Value);
                PopulateProduct(t);
            }
        }
    }
}
