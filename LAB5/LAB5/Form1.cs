using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * 
 */

namespace LAB5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Boolean DoSelectionChange = true;
        public static List<Customer> Customers = new List<Customer>();

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].DefaultCellStyle.Format = "MM//dd//yyyy";
            DoSelectionChange = false;
            PopulateCustomers();
            DoSelectionChange = true;
        }

        
        private void SetDefaults()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            chkContacted.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            DataValidation();

            if (lblOutput.Text != "")
            {

            }
            else
            {
                Customer c = new Customer();
                c.Contacted = this.chkContacted.Checked;
                c.FirstName = this.txtFirstName.Text.Trim();
                c.LastName = this.txtLastName.Text.Trim();
                c.EmailAddress = this.txtEmail.Text.Trim();
                c.PhoneNumber = this.txtPhone.Text.Trim();
                c.Date = DateTime.Now;
                if (Customer.CustomerExists(Customers, c.Id))
                {
                    Customer FoundCustomer = Customer.FindCustomer(Customers, c.Id);
                    Customers.Remove(FoundCustomer);
                }

                Customers.Add(c);
                PopulateCustomers();
                SetDefaults();
            }
        }
        private void PopulateCustomer(Customer c)
        {
            this.txtFirstName.Text = c.FirstName;
            this.txtLastName.Text = c.LastName;
            this.txtEmail.Text = c.EmailAddress;
            this.txtPhone.Text = c.PhoneNumber;
            this.chkContacted.Checked = c.Contacted;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                int selectedID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                Customer c = Customer.FindCustomer(Customers, selectedID);
                PopulateCustomer(c);
                if (DoSelectionChange)
                {
                    SaveCustomer(); 
                }
            }
        }
        private void PopulateCustomers()
        {
            this.dataGridView1.ClearSelection();
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = Customers;
            this.dataGridView1.ClearSelection();

            dataGridView1.Columns[2].Width = 250;
        }
        private void SaveCustomer()
        {
            Customer c = new Customer();
            c.FirstName = this.txtFirstName.Text.Trim();
            c.LastName = this.txtLastName.Text.Trim();
            c.EmailAddress = this.txtEmail.Text.Trim();
            c.PhoneNumber = this.txtPhone.Text.Trim();
            if (Customer.CustomerExists(Customers, c.Id))
            {
                Customer FoundCustomer = Customer.FindCustomer(Customers, c.Id);
                Customers.Remove(FoundCustomer);
            }
            Customers.Add(c);
        }
        
        private void DataValidation()
        {
            if (txtFirstName.Text.Trim() == "")
            {
                lblOutput.Text += "First name is blank\n";
            }
            if (txtLastName.Text.Trim() == "")
            {
                lblOutput.Text += "Last name is blank \n";
            }
            if (txtEmail.Text.Trim() == "")
            {
                lblOutput.Text += "Email address is blank \n";
            }
            else if(!txtEmail.Text.Trim().Contains("@"))
            {
                lblOutput.Text += "Invalid email \n";
            }
            if(txtEmail.Text.Trim().Contains("@."))
            {
                lblOutput.Text += "Missing company name or email service name \n";
            }
            if (!txtEmail.Text.Trim().EndsWith(".com")
                && !txtEmail.Text.Trim().EndsWith(".org")
                && !txtEmail.Text.Trim().EndsWith(".ca")
                && !txtEmail.Text.Trim().EndsWith(".net")
                && !txtEmail.Text.Trim().EndsWith(".us")
                && !txtEmail.Text.Trim().EndsWith(".co") 
                && txtEmail.Text.Trim().Contains("@"))
            {
                lblOutput.Text += "Email address missing domain name \n";
            }
            if (txtPhone.Text.Trim() == "")
            {
                lblOutput.Text += "Phone number is blank \n";
            }
            bool retVal = true;
            retVal = long.TryParse(txtPhone.Text.Trim(), out long validPhoneNumber);
            if (txtPhone.Text.Trim() != "" &&  retVal == false)
            {
                lblOutput.Text += "Phone number is invalid \n";
            }
            else if (txtPhone.Text.Trim() != "" && txtPhone.Text.Trim().Length<10)
            {
                lblOutput.Text += "Phone number must has 10 numbers \n";
            }
        }
    }
}
