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
    public partial class frmAddEdit : Form
    {
        Product currentProduct;
        public frmAddEdit()
        {
            InitializeComponent();
            currentProduct = new Product();
        }
        public frmAddEdit(Product t)
        {
            InitializeComponent();
            currentProduct = new Product();
            currentProduct = t;
        }

        List<String> Size = new List<String>();
        List<String> Category = new List<String>();
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
        private void PopulateProduct(Product t)
        {
            this.nudQuantity.Value = t.Quantity;
            this.txtName.Text = t.ProductName;
            this.cboCategory.SelectedItem = t.Category;
            this.cboSize.SelectedItem = t.Size;
            this.lblPrimaryColor.BackColor = t.PrimaryColor;
            this.lblSecondaryColor.BackColor = t.SecondaryColor;
        }
        private void SaveProduct()
        {
            Product t = new Product();
            t.Quantity = decimal.ToInt32(this.nudQuantity.Value);
            t.ProductName = this.txtName.Text.Trim();
            t.Category = this.cboCategory.SelectedValue.ToString();
            t.Size = this.cboSize.SelectedValue.ToString();
            t.PrimaryColor = this.lblPrimaryColor.BackColor;
            t.SecondaryColor = this.lblSecondaryColor.BackColor;

            frmMain.Products.Add(t);
        }
        #endregion
        private void frmAddEdit_Load(object sender, EventArgs e)
        {
            PopulateCategory();
            PopulateSize();
            this.cboCategory.DataSource = Category;
            this.cboSize.DataSource = Size;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveProduct();
            SetDefaults();
        }

        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            SaveProduct();
            this.Close();
        }
    }
}
