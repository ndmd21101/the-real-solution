using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPProducts
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region GLOBAL VARS
        List<String> Brands = new List<String>();
        List<Products> PProducts = new List<Products>();
        #endregion

        #region EVENT HANDLERS
        /// <summary>
        /// Main form loading commands
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            PopulateBrands();
            cboPlanets.DataSource = Brands;
            Products.GetSampleProducts();
            SetMyCustomFormat();
        }

        private void btnSetHairColour_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            lblHairColour.BackColor = colorDialog1.Color;
        }

        private void btnSetEyeColour_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            lblEyeColour.BackColor = colorDialog1.Color;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        #endregion

        #region CUSTOM METHODS
        private void PopulateBrands()
        {
            Brands.Add("Supreme");
            Brands.Add("Louis Vuitton");
            Brands.Add("Hermes");
            Brands.Add("Gucci");
            Brands.Add("Dior");
            Brands.Add("Versace");
            Brands.Add("Burberry");
            Brands.Add("Chanel");
            Brands.Add("Prada");
            Brands.Add("Saint Laurent");
            Brands.Add("George");
            Brands.Add("Nike");
            Brands.Add("Adidas");
            Brands.Add("Vans");
            Brands.Add("UNIQLO");
        }

        private void SetDefaults()
        {
            lblHairColour.BackColor = Color.Gray;
            lblEyeColour.BackColor = Color.Gray;
            txtNickName.Clear();
            txtUnit.Clear();
            cboPlanets.SelectedIndex = -1;
            dtpBorn.Value = DateTime.Now;
            nudDesignation.Value = 0;
            chkDefective.Checked = false;
        }
        
        private void SetMyCustomFormat()
        {
            dtpBorn.Format = DateTimePickerFormat.Custom;
            dtpBorn.CustomFormat = "yyyy";
            
        }

        private void PopulateProductList()
        {
            this.dgvClones.DataSource = null;
            this.dgvClones.Rows.Clear();
            foreach (Products d in Products.Product)
            {
                dgvClones.Rows.Add(d.ItemsQuantity);
            }
        }

        #endregion






        private void btnSave_Click(object sender, EventArgs e)
        {
            Products tempProduct = new Products();
            tempProduct.ItemsQuantity = Convert.ToString(this.nudDesignation);
            tempProduct.ProductCategory = this.txtNickName.Text.Trim();
            tempProduct.IsInStock = this.chkDefective.Checked;
            tempProduct.PrimaryColor = this.lblHairColour.BackColor;
            tempProduct.SecondaryColor = this.lblEyeColour.BackColor;
            Products.Product.Add(tempProduct);
            PopulateProductList();
            SetDefaults();
        }

        private void dtpBorn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboPlanets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
