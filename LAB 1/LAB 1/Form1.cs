#region Comment Header
/* 
 Name: Nguyen Duc
 Date: 30th Jan, 2022
 ID: 100820410
 Title: NETD2202 - Average Weekly Cases
 */
#endregion
#region Using Section
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

namespace LAB_1
{
    public partial class Form1 : Form
    {
        #region Main Function
        public Form1()
        {
            InitializeComponent();
        }
        #endregion
        int date = 1;
        #region Click Events
        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit", "Exit Confirmation",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        public void button1_Click(object sender, EventArgs e)
        {
            if (date <= 6)
            {
                date += 1;
                label2.Text = "Day" + " " + date;
            }
            
            if (txtCasesNumber.Text.Trim().Length >= 1 && lblCasesNumber.Items.Count <7)
            {
                if (int.TryParse(txtCasesNumber.Text.Trim(), out int cases))
                {
                    lblCasesNumber.Items.Add(txtCasesNumber.Text.Trim());
                    txtCasesNumber.Clear();
                    txtCasesNumber.Focus();
                    
                }


                else
                {
                    MessageBox.Show("Enter a number", "Input Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            
            if (lblCasesNumber.Items.Count == 7)
            {
                txtCasesNumber.ReadOnly = true;
                avgCalculate();
                btnEnter.Visible = false;
                
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        #region Custom Functions
        private void SetDefaults()
        {
            txtCasesNumber.Clear();
            lblOuput.Text = string.Empty;
            lblCasesNumber.Items.Clear();
            txtCasesNumber.Focus();
            txtCasesNumber.ReadOnly = false;
            btnEnter.Visible = true;
            label2.Text = "Day 1";
            date = 1;

        }

        #endregion

        #endregion

        private void lblCasesNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            
        }
        private void avgCalculate()
        {
            double avg = 0, sum = 0;
            int lstCount = lblCasesNumber.Items.Count; 
            for (int i = 0; i < lstCount; i++)
            {
                sum += Convert.ToDouble(lblCasesNumber.Items[i]);
            }
            avg = sum / lstCount;
            lblOuput.Text = "Average per day: " + avg;
            lblOuput.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.K)
            {
                btnExit.PerformClick();
            }
        }
    }

}
