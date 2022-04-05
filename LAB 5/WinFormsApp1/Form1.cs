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
/*
 * Name: Nguyen Duc
 * Date: April 4th, 2022
 * Description: Text Editor
 * URL: https://github.com/ndmd21101/the-real-solution
 */
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            
            InitializeComponent();
        }
        bool nonExist = true;
        int counter = 0;
        private void msHelpAbout_Click(object sender, EventArgs e)
        {
            frmAbout frmNew = new frmAbout();
            frmNew.ShowDialog();
            frmNew.Dispose();
        }

        private void msFileNew_Click(object sender, EventArgs e)
        {
            rtbTextEditor.Clear();
            nonExist = true;
            counter = 0;
        }

        private void msFileOpen_Click(object sender, EventArgs e)
        {
            OpenFile();
            nonExist = true;
            counter = 0;
        }

        private void msFileSave_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void msFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void msEditCopy_Click(object sender, EventArgs e)
        {
            CopyText();
        }
        private void msEditPaste_Click(object sender, EventArgs e)
        {
            PasteText();
        }
        private void msEditCut_Click(object sender, EventArgs e)
        {
            CopyText();
            rtbTextEditor.SelectedText = "";
        }
        private void msFileSaveAs_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        private void OpenFile()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "CSV Files |*.csv| Text Files |*.txt";
            openFile.Title = "Open File";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                rtbTextEditor.Clear();
                using (StreamReader sr = new StreamReader(openFile.FileName))
                {
                    rtbTextEditor.Text = sr.ReadToEnd();
                    sr.Close();
                }
            }
        }
        private void SaveFile()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "CSV Files |*.csv| Text Files |*.txt";
            saveFile.Title = "Save File";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter txtOuput = new StreamWriter(saveFile.FileName);
                txtOuput.Write(rtbTextEditor.Text);
                txtOuput.Close();
            }
        }
        private void CopyText()
        {
            Clipboard.SetText(rtbTextEditor.SelectedText);
        }
        private void PasteText()
        {
            string copiedtext = Clipboard.GetText();
            rtbTextEditor.Text = rtbTextEditor.Text.Insert(rtbTextEditor.SelectionStart, copiedtext);
        }

        private void rtbTextEditor_TextChanged(object sender, EventArgs e)
        {
            lblChange.Text = "This file is unsaved";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

    }
}
