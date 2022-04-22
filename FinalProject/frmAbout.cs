#region Comment Header
/*
 * Author : Sujeeve Sureshkumar
 * Date: April 4th, 2022
 * GitHub URL: https://github.com/SujeeveSuresh/NETD
 * GitHub Website: Lab Assignment
 * ID: 100790769
 * Title: NETD2202 - Lab 05
 * Description: this is the about file
 */
#endregion

#region USING
using System;
using System.Windows.Forms;
#endregion

namespace FinalProject
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }
       
        /// <summary>
        /// exit function closes the about tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
