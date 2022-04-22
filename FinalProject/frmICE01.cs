/* ----------------------------------
 * Author: Sujeeve Sureshkumar
 * Date: January 20th 2022
 * Title: Week 2 - ICE01 
 * Description:
 *      A basic application that has 2 buttons and a label
 *      when the mouse hovers over the no button it should move,
 *      when the user clicks yes it should open a popup message.
 */
using System;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class frmICE01 : Form
    {
        public frmICE01()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)//when the yes button is clicked, it brings a message box, the application can close from there
        {
            MessageBox.Show("Yes, Sujeeve Sureshkumar is awesome, aren't they!");

            this.Close ();
            
        }

        private void btnNo_MouseHover (object sender, EventArgs e) //when you hover over the no button it moves to the left by 200
            
        {
            btnNo.Left = 200;
        }


        private void btnNo_MouseMove(object sender, MouseEventArgs e)//when you hover over the no button again it moves back to the original position
        {
            btnNo.Left = 100;
        }

    }
}
