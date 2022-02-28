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
 Name: Nguyen Duc
 Title: LAB 3
 Github URL: https://github.com/ndmd21101/the-real-solution
 Date: 27th Feb, 2022
 */
namespace LAB_3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }
        #region
        int[,] casesGrid;
        int x = 0;
        int y = 0;
        int totalCasesRegion1 = 0;
        int totalCasesRegion2 = 0;
        int totalCasesRegion3 = 0;
        double avgRegion1 = 0;
        double avgRegion2 = 0;
        double avgRegion3 = 0;
        double totalAvg = 0;
        #endregion
        private void btnEnter_Click(object sender, EventArgs e)
        {
            Validation();
            AddItems();
            AssignValue();
           
            txtCases.Focus();
            txtCases.Clear();
            if(lstRegion1.Items.Count==7 && lstRegion2.Items.Count == 7 && lstRegion3.Items.Count == 7)
            {
                btnEnter.Enabled = false;
            }
            //lblRegion1.Font = new Font(lblRegion1.Font,FontStyle.Bold);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           casesGrid = new int[3, 7];
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    casesGrid[x, y] = 0;
                }
            }
        }
        #region Custom Methods
        private void AddItems()
        {

            
            
               
                if (txtCases.Text.Trim().Length > 1 && lstRegion1.Items.Count < 7)
                {
                    lstRegion1.Items.Add(txtCases.Text);
                   
                    
                }
                else if (txtCases.Text.Trim().Length > 1 && lstRegion2.Items.Count < 7 && lstRegion1.Items.Count == 7)
                {
                    lstRegion2.Items.Add(txtCases.Text);
                   
                }
                else if (txtCases.Text.Trim().Length > 1 && lstRegion3.Items.Count < 7 && lstRegion1.Items.Count == 7 && lstRegion2.Items.Count == 7)
                {
                    lstRegion3.Items.Add(txtCases.Text);
                    
                    
                }
               else
                {
                    lblTotalAvg.Text = "Error - Input has to be a number. Please try again.";
                }

            
               
            
        }
        private void AssignValue()
        {
           

            if (x <= 2)
            {
                if (y <= 6)
                {
                    
                    casesGrid[x, y] = Convert.ToInt32(txtCases.Text);
                    if (x==0)
                    {   
                        totalCasesRegion1 += casesGrid[x, y];
                    }
                    if(x==1)
                    {   
                        totalCasesRegion2 += casesGrid[x, y];
                    }
                    if(x==2)
                    {
                       
                        totalCasesRegion3 += casesGrid[x, y];
                    }
                    y++;
                }
                if(y==7)
                {
                    x++;
                    y = 0;
                }
            }
            if(lstRegion1.Items.Count==7 && lstRegion2.Items.Count<7)
            {
                
                avgRegion1 = totalCasesRegion1 / 7;
                lblAvgRegion1.Text = Convert.ToString(avgRegion1);
            }
            if (lstRegion2.Items.Count == 7)
            {
                avgRegion2 = totalCasesRegion2 / 7;
                lblAvgRegion2.Text = Convert.ToString(avgRegion2);
            }
            if (lstRegion3.Items.Count == 7)
            {
                
                avgRegion3 = totalCasesRegion3 / 7;
                lblAvgRegion3.Text = Convert.ToString(avgRegion3);
            }
            if (lstRegion1.Items.Count == 7 && lstRegion2.Items.Count == 7 && lstRegion3.Items.Count == 7)
            {
                totalAvg = (avgRegion1 + avgRegion2 + avgRegion3) / 3;
                lblTotalAvg.Text = Convert.ToString(totalAvg);
            }

            
        }
        private void SetDefaults()
        {
            lstRegion1.Items.Clear();
            lstRegion2.Items.Clear();
            lstRegion1.Items.Clear();
            btnEnter.Enabled = true;
            lblAvgRegion1.Text = "";
            lblAvgRegion2.Text = "";
            lblAvgRegion3.Text = "";
            lblTotalAvg.Text = "";
        }

        #endregion

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Validation()
        {
            
        }
    }

}
