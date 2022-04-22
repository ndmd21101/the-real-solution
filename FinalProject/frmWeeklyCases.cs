#region Comment Header
/*
 * Author : Sujeeve Sureshkumar
 * Date: Jan 30, 2022
 * GitHub URL: https://github.com/SujeeveSuresh/NETD
 * GitHub Website: Testing in the website editor
 * ID: 100790769
 * Title: NETD2202 - Lab 01
 * Description: In this lab I created a windows form that displays the 
 *              average cases found per day in a week.
 */
#endregion

#region Using Section
using System;
using System.Windows.Forms;
#endregion

namespace FinalProject
{
    public partial class frmWeeklyCases : Form
    {
        #region Main Function

        public frmWeeklyCases()
        {
            InitializeComponent();
        }

        #endregion

        /// <summary>
        ///This int had to be in the start of the code because the counter runs in 
        ///the main frame I had this in the btnEnter function and it wouldnt work, 
        ///once i tried putting it at the start it started working.
        /// </summary>
        
        //Day counter declaration 
        int days = 0;

        #region Click Events

        /// <summary>
        /// Click event for the enter button, Moves entered number into the cases list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnter_Click(object sender, EventArgs e)
        {
            Double numTotal = 0;
            Double average = 0;

            if (txtCases.Text.Trim().Length > 0)
            {
                lbxCases.Items.Add(txtCases.Text);
                txtCases.Clear();
                txtCases.Focus();
            }else
            {
                MessageBox.Show("Number is not in range, Try Again!");
                txtCases.Clear();
                txtCases.Focus();
                txtCases.SelectAll();
            }

            days = days + 1;
            lblCount.Text = days.ToString();

            if (days == 7)
            {
                btnEnter.Enabled = false;
                txtCases.Enabled = false;
                       
                for (int i = 0; i < lbxCases.Items.Count; i++)
                {
                    numTotal += Convert.ToInt32(lbxCases.Items[i]);
                    average = numTotal / lbxCases.Items.Count;
                
                }

                Math.Round(average, 2);
                txtOutput.Text = "Average per day: " + (Math.Round(average,2));

            }
        }

        /// <summary>
        /// Click event for the reset button, resets all items to the default location and values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaults();   
        }
        
        /// <summary>
        /// Click event for the exit button, exits application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the program?","Exit Confrimation",
                MessageBoxButtons.YesNo)==DialogResult.Yes)
                
            {
                this.Close();
            }
        }
         
        #endregion

        #region Custom Methods
        private void SetDefaults()
        {
            //Emptys users input boxes
            txtCases.Clear();
            txtCases.Text = string.Empty;
            lblCount.Text = string.Empty;
            lbxCases.Items.Clear();
            txtOutput.Text = string.Empty;
            lblCount.Text = string.Empty;
          
            //Re-enabling buttons
            btnEnter.Enabled = true;
            txtCases.Enabled = true;

            //Setting the day counter back to 0
            days = 0;

            //Set cursor to the default location
            txtCases.Focus();

        }

        #endregion

        #region Event
        /// <summary>
        /// This event makes sure that the buttons entered are only wholenumbers it also doesnt allow alphabets to be entered.
        /// Reference: https://www.youtube.com/watch?v=u3b9pY1b1_U 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCases_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

      
    }
}
