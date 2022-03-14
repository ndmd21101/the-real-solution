using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        List<Products> Product = new List<Products>();
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
            Product = Products.GetSampleProducts();
            PopulateProductList();
            
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
            this.dgvProducts.DataSource = Product;
            this.dgvProducts.ClearSelection();
        }
       
        #endregion






       

       
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            
            Products t = new Products();
            t.Category = this.cboCategory.SelectedItem.ToString();
            t.Size = this.cboCategory.SelectedItem.ToString();
            t.Quantity = decimal.ToInt32(this.nudQuantity.Value);
            t.ProductName = this.txtName.Text.Trim();
            t.PrimaryColor = this.lblPrimaryColor.BackColor;
            t.SecondaryColor = this.lblSecondaryColor.BackColor;
            Product.Add(t);
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
    }
}
