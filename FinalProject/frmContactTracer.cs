#region Comment Header
/*
 * Author : Sujeeve Sureshkumar
 * Date: March 25th, 2022
 * GitHub URL: https://github.com/SujeeveSuresh/NETD
 * GitHub Website: Testing in the website editor
 * ID: 100790769
 * Title: NETD2202 - Lab 04
 * Description: In this lab I created a windows that displays customer information that has been validated.
 */
#endregion
#region USING 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion
namespace FinalProject
{
    public partial class frmContactTracer : Form
    {
        public frmContactTracer()
        {
            InitializeComponent();
        }

        #region GLOBAL VARS
        List<Contact> Contacts = new List<Contact>();
        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            //form loads on 
            SetDefaults();
        }

        #region BUTTONS

        /// <summary>
        /// Enter button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnter_Click(object sender, EventArgs e)
        {
            lblOutput.Text = string.Empty;
            if (IsValid(txtFirst.Text, txtLast.Text, txtEmail.Text, txtPhone.Text))
            {

                Contact c = new Contact();

                c.FirstName = this.txtFirst.Text.Trim();
                c.LastName = this.txtLast.Text.Trim();
                c.EmailAddress = this.txtEmail.Text.Trim();
                c.PhoneNumber = this.txtPhone.Text.Trim();
                c.ContactStatus = this.chkContact.Checked;

                //add contacts to list
                Contacts.Add(c);

                //populates contacts to the list
                populateContacts();

                //setdefaults
                SetDefaults();

            }
        }

        /// <summary>
        /// reset button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        /// <summary>
        /// Exit button this allows us to close the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region CUSTOM

        /// <summary>
        /// Set default where it resets all my input boxes
        /// </summary>
        private void SetDefaults()
        {
            txtFirst.Focus();
            txtFirst.Clear();
            txtLast.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            chkContact.Checked = false;

          
        }

        /// <summary>
        /// populates my data grid view
        /// </summary>
        private void populateContacts()
        {
            this.dgvTracer.ClearSelection();
            this.dgvTracer.DataSource = null;
            this.dgvTracer.DataSource = Contacts;
            this.dgvTracer.ClearSelection();
        }
        private bool IsValid(string firstName , string lastName, string email, string phone)
        {
            // Assume the worker is valid.
            bool isValid = true;

      
            // firstname validation
            if (firstName == String.Empty)
            {
                // If it's not valid display error message write 
                isValid &= false;
                lblOutput.Text += "You must enter a first name.\n";
            }

            // lastname validation
            if (lastName == String.Empty)
            {
                // If it's not valid display error message write 
                isValid &= false;
                lblOutput.Text += "You must enter a last name.\n";
            }

            // email validation
            if (email == String.Empty )
            {
                // If it's not valid display error message write 
                isValid &= false;
                lblOutput.Text += "You must enter a valid email.\n";
            }
            else if (!txtEmail.Text.Trim().Contains("@") || !txtEmail.Text.Trim().Contains(".") || txtEmail.Text.Trim().Contains("@."))
            {
                // If it's not valid display error message write 
                isValid &= false;
                lblOutput.Text += "You must enter a valid email. Missing @ domain \n";
            }



            // phone number validation
            isValid = Int64.TryParse(txtPhone.Text.Trim(),out Int64 phonevalid);

            if (phone == String.Empty && txtPhone.Text.Trim().Length < 10)
            {
                // If it's not valid display error message write 
                isValid &= false;
                lblOutput.Text += "You must enter a valid phone number.\n";
            }
            else if (isValid == false)
            {
                lblOutput.Text += "Phone MUST! be 10 numeric digits.\n";
            }

            return isValid;
        }
        #endregion






    }
}
