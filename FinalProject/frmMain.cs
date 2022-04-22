#region MAIN
#region CommentHeader
/*
 * Author :Duc Nguyen , Sujeeve Sureshkumar
 * Date: April 4th, 2022
 * Sujeeve's GitHub URL: https://github.com/SujeeveSuresh/NETD
 * Duc's GitHub URL : https://github.com/ndmd21101/the-real-solution
 * GitHub Website: Lab Assignment
 * ID: 100790769
 * Title: NETD2202 - Final Project
 * Description: In this lab we created a MDI form that has most of our labs and ices we worked on during this semester.
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
using System.IO;
#endregion

namespace FinalProject
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //Menu strip tabs
        #region MENUSTRIP

        #region AboutTab

        /// <summary>
        /// About tab, Tells the users about the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msHelpAbout_Click(object sender, EventArgs e)
        {
            //opens a new form
            frmAbout frm = new frmAbout();
            //opens the dialog
            frm.ShowDialog();
            //disposes the dialog so it doesnt waste more memory for everytime your open the about file.
            frm.Dispose();

        }
        #endregion

        #region WindowTab

        /// <summary>
        /// Makes the windows into cascade
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msWindowCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        /// <summary>
        /// Makes the windows into vertical tiles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msWindowTileVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);

        }

        /// <summary>
        /// Makes the windows into a horizontal tiles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msWindowTileHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);

        }
        #endregion

        #region WindowTabLabs

        /// <summary>
        /// Opens lab 1 the weekly cases form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msWindowWeeklyCases_Click(object sender, EventArgs e)
        {
            //opens a new form
            frmWeeklyCases frm = new frmWeeklyCases();
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        /// <summary>
        /// Opens lab 4 the contact tracer form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msWindowContactTracer_Click(object sender, EventArgs e)
        {
            //opens a new form
            frmContactTracer frm = new frmContactTracer();
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        /// <summary>
        /// Opens lab 2 the gpa calculator form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openGPACalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens a new form
            frmGPA frm = new frmGPA();
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        /// <summary>
        /// Opens lab 5 the text editor form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msWindowTextEditor_Click(object sender, EventArgs e)
        {
            //opens a new form
            frmTextEditor frm = new frmTextEditor();
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        #endregion

        #region WindowTabICES

        /// <summary>
        /// This opens the ice01 form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msWindowOpenICE01_Click(object sender, EventArgs e)
        {
            //opens a new form
            frmICE01 frm = new frmICE01();
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        /// <summary>
        /// This opens the ice04 form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msWindowOpenICE04_Click(object sender, EventArgs e)
        {
            //opens a new form
            frmICE04 frm = new frmICE04();
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        /// <summary>
        /// This opens the ice05 form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msWindowOpenICE05_Click(object sender, EventArgs e)
        {
            //opens a new form
            formCustomerEntry frm = new formCustomerEntry();
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        #endregion

        #region EditTab

        /// <summary>
        /// Private void for cut this cuts the text saves it to the clipboard so it can be used on other forms also
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msEditCut_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
            {

                foreach (Control c in f.Controls)
                {
                    if (c.Focused)
                    {
                        if (c is TextBox)
                        {
                            Clipboard.SetText(((TextBox)c).SelectedText);
                            ((TextBox)c).Text = "";
                        }
                    }
                }

            }
        }

        /// <summary>
        /// Private void for copy this copies the text saves it to the clipboard so it can be used on other forms also
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msEditCopy_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
            {


                foreach (Control c in f.Controls)
                {
                    if (c.Focused)
                    {
                        if (c is TextBox)
                        {
                            Clipboard.SetText(((TextBox)c).SelectedText);
                        }
                    }
                }

            }
        }

        /// <summary>
        /// Private void for paste this pastes the text onto any textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msEditPaste_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
            {

                foreach (Control c in f.Controls)
                {
                    if (c.Focused)
                    {
                        if (c is TextBox)
                        {
                            ((TextBox)c).Text = ((TextBox)c).Text.Insert(((TextBox)c).SelectionStart,
                                ((TextBox)c).Text = Clipboard.GetText());
                        }
                    }
                }

            }
        }

        /// <summary>
        /// Private void to highlight all texts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msEditSelectAll_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
            {


                foreach (Control c in f.Controls)
                {
                    if (c.Focused)
                    {
                        if (c is TextBox)
                        {
                           ((TextBox)c).SelectAll();
                        }
                    }
                }

            }
        }


        #endregion

        #region FileTab

        /// <summary>
        /// This exits the whole application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This closes the form that is focused 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msFileClose_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
        }

        /// <summary>
        /// This opens files that can be put on a text editor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {

                string FileName = openFileDialog.FileName;
                FileStream fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        /// <summary>
        /// This saves the file that requires a text into a text file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msFileSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveas = new SaveFileDialog();

            saveas.Title = "Save a Text File";
            saveas.Filter = "Text File (*.txt)|*.txt|All Files (*.*)|*.*";

            DialogResult dialog = saveas.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveas.FileName);

                Form ChildForm = this.ActiveMdiChild;

                if (ChildForm != null)
                {
                    TextBox textboxes = ChildForm.ActiveControl as TextBox;

                    if (textboxes != null)
                    {
                        sw.Write(textboxes.Text);
                    }

                    sw.Close();
                }
            }
        }

        /// <summary>
        /// This saves the file that requires a text into a text file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msFileSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveas = new SaveFileDialog();

            saveas.Title = "Save a Text File";
            saveas.Filter = "Text File (*.txt)|*.txt|All Files (*.*)|*.*";

            DialogResult dialog = saveas.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveas.FileName);

                Form ChildForm = this.ActiveMdiChild;

                if (ChildForm != null)
                {
                    TextBox textboxes = ChildForm.ActiveControl as TextBox;

                    if (textboxes != null)
                    {
                        sw.Write(textboxes.Text);
                    }

                    sw.Close();

                }
            }
        }

        /// <summary>
        /// This opens a new text editor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msFileNew_Click(object sender, EventArgs e)
        {
            //opens a new form
            frmTextEditor frm = new frmTextEditor();
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }


        #endregion

        #endregion

    
    }
}

#endregion