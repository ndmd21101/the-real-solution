
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msFile = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.msEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.msEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.msEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.msEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.msHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.msHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbTextEditor = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblChange = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFile,
            this.msEdit,
            this.msHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msFile
            // 
            this.msFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFileNew,
            this.msFileOpen,
            this.msFileSave,
            this.msFileSaveAs,
            this.msFileClose,
            this.msFileExit});
            this.msFile.Name = "msFile";
            this.msFile.Size = new System.Drawing.Size(37, 20);
            this.msFile.Text = "File";
            // 
            // msFileNew
            // 
            this.msFileNew.Name = "msFileNew";
            this.msFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.msFileNew.Size = new System.Drawing.Size(146, 22);
            this.msFileNew.Text = "New";
            this.msFileNew.Click += new System.EventHandler(this.msFileNew_Click);
            // 
            // msFileOpen
            // 
            this.msFileOpen.Name = "msFileOpen";
            this.msFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.msFileOpen.Size = new System.Drawing.Size(146, 22);
            this.msFileOpen.Text = "Open";
            this.msFileOpen.Click += new System.EventHandler(this.msFileOpen_Click);
            // 
            // msFileSave
            // 
            this.msFileSave.Name = "msFileSave";
            this.msFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.msFileSave.Size = new System.Drawing.Size(146, 22);
            this.msFileSave.Text = "Save";
            this.msFileSave.Click += new System.EventHandler(this.msFileSave_Click);
            // 
            // msFileSaveAs
            // 
            this.msFileSaveAs.Name = "msFileSaveAs";
            this.msFileSaveAs.Size = new System.Drawing.Size(146, 22);
            this.msFileSaveAs.Text = "Save as";
            this.msFileSaveAs.Click += new System.EventHandler(this.msFileSaveAs_Click);
            // 
            // msFileClose
            // 
            this.msFileClose.Name = "msFileClose";
            this.msFileClose.Size = new System.Drawing.Size(146, 22);
            this.msFileClose.Text = "Close";
            // 
            // msFileExit
            // 
            this.msFileExit.Name = "msFileExit";
            this.msFileExit.Size = new System.Drawing.Size(146, 22);
            this.msFileExit.Text = "Exit";
            this.msFileExit.Click += new System.EventHandler(this.msFileExit_Click);
            // 
            // msEdit
            // 
            this.msEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msEditCopy,
            this.msEditCut,
            this.msEditPaste});
            this.msEdit.Name = "msEdit";
            this.msEdit.Size = new System.Drawing.Size(39, 20);
            this.msEdit.Text = "Edit";
            // 
            // msEditCopy
            // 
            this.msEditCopy.Name = "msEditCopy";
            this.msEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.msEditCopy.Size = new System.Drawing.Size(144, 22);
            this.msEditCopy.Text = "Copy";
            this.msEditCopy.Click += new System.EventHandler(this.msEditCopy_Click);
            // 
            // msEditCut
            // 
            this.msEditCut.Name = "msEditCut";
            this.msEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.msEditCut.Size = new System.Drawing.Size(144, 22);
            this.msEditCut.Text = "Cut";
            this.msEditCut.Click += new System.EventHandler(this.msEditCut_Click);
            // 
            // msEditPaste
            // 
            this.msEditPaste.Name = "msEditPaste";
            this.msEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.msEditPaste.Size = new System.Drawing.Size(144, 22);
            this.msEditPaste.Text = "Paste";
            this.msEditPaste.Click += new System.EventHandler(this.msEditPaste_Click);
            // 
            // msHelp
            // 
            this.msHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msHelpAbout});
            this.msHelp.Name = "msHelp";
            this.msHelp.Size = new System.Drawing.Size(44, 20);
            this.msHelp.Text = "Help";
            // 
            // msHelpAbout
            // 
            this.msHelpAbout.Name = "msHelpAbout";
            this.msHelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.msHelpAbout.Size = new System.Drawing.Size(126, 22);
            this.msHelpAbout.Text = "About";
            this.msHelpAbout.Click += new System.EventHandler(this.msHelpAbout_Click);
            // 
            // rtbTextEditor
            // 
            this.rtbTextEditor.Location = new System.Drawing.Point(0, 27);
            this.rtbTextEditor.Name = "rtbTextEditor";
            this.rtbTextEditor.Size = new System.Drawing.Size(800, 422);
            this.rtbTextEditor.TabIndex = 1;
            this.rtbTextEditor.Text = "";
            this.rtbTextEditor.TextChanged += new System.EventHandler(this.rtbTextEditor_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "CSV Files |*.csv| Text Files |*.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CheckFileExists = true;
            this.saveFileDialog1.DefaultExt = "csv";
            this.saveFileDialog1.Filter = "CSV Files|*.csv|Text Files|*.txt";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(737, 6);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(0, 15);
            this.lblChange.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.rtbTextEditor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Text Editor - Duc Nguyen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msFile;
        private System.Windows.Forms.ToolStripMenuItem msFileNew;
        private System.Windows.Forms.ToolStripMenuItem msFileOpen;
        private System.Windows.Forms.ToolStripMenuItem msFileSave;
        private System.Windows.Forms.ToolStripMenuItem msFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem msFileClose;
        private System.Windows.Forms.ToolStripMenuItem msFileExit;
        private System.Windows.Forms.ToolStripMenuItem msEdit;
        private System.Windows.Forms.ToolStripMenuItem msEditCopy;
        private System.Windows.Forms.ToolStripMenuItem msEditCut;
        private System.Windows.Forms.ToolStripMenuItem msEditPaste;
        private System.Windows.Forms.ToolStripMenuItem msHelp;
        private System.Windows.Forms.ToolStripMenuItem msHelpAbout;
        private System.Windows.Forms.RichTextBox rtbTextEditor;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblChange;
    }
}

