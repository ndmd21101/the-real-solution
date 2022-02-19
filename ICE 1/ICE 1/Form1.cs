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
//Date: 22nd Jan, 2022
//App: Awesomeness
//Description: Just to show the person who created this app is awesome
namespace ICE_1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button2_MouseHover(object sender, EventArgs e)
        {

            Point button2NewLocation = new Point(115, 200);
            Point startPoint = new Point(200, 200);
            if (button2.Location == startPoint)
            {
                button2.Location = button2NewLocation;

            }
            else if (button2.Location == button2NewLocation)
            {
                button2.Location = startPoint;
            }
            
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Yes = new Form2();
            Yes.Show();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
