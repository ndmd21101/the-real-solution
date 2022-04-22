#region Comment Header
/*
 * Author : Sujeeve Sureshkumar
 * Date: April 4th, 2022
 * GitHub URL: https://github.com/SujeeveSuresh/NETD
 * GitHub Website: Lab Assignment
 * ID: 100790769
 * Title: NETD2202 - Lab 05
 * Description: In this lab I created a Text editor that can open save , open new file ,copy cut and paste.
 */
#endregion


#region USING
using System;
using System.IO;
using System.Windows.Forms;
#endregion

namespace FinalProject
{
    
    public partial class frmTextEditor : Form
    { 


        public frmTextEditor()
        {
            InitializeComponent();
        }


        #region Custom MenuStrip

        /// <summary>
        /// This is the copy function where the user can copy the text in the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msCopy_Click(object sender, EventArgs e)
        {
            //tbx main is the main textbox
            tbxMain = this.ActiveControl as TextBox;

            // if the textbox main is highlighted when trying to highlight the text it will copy it to your clipboard
            if (tbxMain.SelectedText != string.Empty)
                Clipboard.SetData(DataFormats.Text, tbxMain.SelectedText);
        }

        /// <summary>
        /// cut function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msCut_Click(object sender, EventArgs e)
        {
            tbxMain = this.ActiveControl as TextBox;
            //this will cut the highlighted text to your clipboard
            if (tbxMain.SelectedText != string.Empty)
                Clipboard.SetData(DataFormats.Text, tbxMain.SelectedText);
            tbxMain.SelectedText = string.Empty;
        }

        /// <summary>
        /// paste function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msPaste_Click(object sender, EventArgs e)
        {
            //this will paste the info in your clipboard to the textbox
            int paste = ((TextBox)this.ActiveControl).SelectionStart;
            this.ActiveControl.Text = this.ActiveControl.Text.Insert(paste, Clipboard.GetText());
        }



        /// <summary>
        /// This allows the user to open a existing text file on your pc.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msOpen_Click(object sender, EventArgs e)
        {
            //open file dialog
            OpenFileDialog openfiledialog = new OpenFileDialog();

            //filters so it will be only text files can be opened
            openfiledialog.Filter = "Text Files|*.txt";
            openfiledialog.DefaultExt = "txt";
            openfiledialog.AddExtension = true;

            //if you choose the file you want to open it will clear the old items in the textbox and replace it with the file you opened.
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                tbxMain.Clear();
                
                string openfilename = openFileDialog1.FileName;
                using (FileStream fs = new FileStream(openfilename, FileMode.Create, FileAccess.Write))
                {
                    StreamReader sr = new StreamReader(openfiledialog.FileName);
                    tbxMain.Text = sr.ReadToEnd();
                    sr.Close();
                }
            }
        }

        /// <summary>
        /// save function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msSave_Click(object sender, EventArgs e)
        {


        }

        /// <summary>
        /// save as function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msSaveAs_Click(object sender, EventArgs e)
        {
            //opens the save file dialog
            SaveFileDialog savefiledialog = new SaveFileDialog();
            //this filters the save file dialog so you can only save the file as a .txt
            savefiledialog.Filter = "Text Files|*.txt";
            savefiledialog.DefaultExt = "txt";
            savefiledialog.AddExtension = true;

            //if the save file dialog is open you can choose what path you want to save your file and it will save the file to a .txt
            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                var destination = savefiledialog.FileName;
                StreamWriter sr = new StreamWriter(destination);
                sr.Write(tbxMain.Text);
                sr.Close();
            }
        }

        /// <summary>
        /// this new will open a new text editor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msNew_Click(object sender, EventArgs e)
        {
            //clears the textbox 
            tbxMain.Clear();

        }

        /// <summary>
        /// closes the application exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
         private void msExit_Click(object sender, EventArgs e)
        {
            //exits applicaiton
            Application.Exit();

        }

        /// <summary>
        /// close function which will close a file thats already open and replace it with a blank text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msClose_Click(object sender, EventArgs e)
        {
            //clears text box
            tbxMain.Clear();
        }


        #endregion

     
    }
}
