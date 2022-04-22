
namespace FinalProject
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.msFile = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.msEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.msEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.msEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.msEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.msEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.msWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.msWindowCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.msWindowTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.msWindowTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.msWindowWeeklyCases = new System.Windows.Forms.ToolStripMenuItem();
            this.msWindowContactTracer = new System.Windows.Forms.ToolStripMenuItem();
            this.msWindowOpenGPA = new System.Windows.Forms.ToolStripMenuItem();
            this.msWindowTextEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.msWindowOpenICE01 = new System.Windows.Forms.ToolStripMenuItem();
            this.msWindowOpenICE04 = new System.Windows.Forms.ToolStripMenuItem();
            this.msWindowOpenICE05 = new System.Windows.Forms.ToolStripMenuItem();
            this.msHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.msHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFile,
            this.msEdit,
            this.msWindow,
            this.msHelp});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(800, 28);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "msMain";
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
            this.msFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.msFile.Size = new System.Drawing.Size(46, 24);
            this.msFile.Text = "&File";
            this.msFile.ToolTipText = "File has options for New, Open, Save, Save As, Close amd Exit";
            // 
            // msFileNew
            // 
            this.msFileNew.Name = "msFileNew";
            this.msFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.msFileNew.Size = new System.Drawing.Size(224, 26);
            this.msFileNew.Text = "&New";
            this.msFileNew.ToolTipText = "Opens a new text editor";
            this.msFileNew.Click += new System.EventHandler(this.msFileNew_Click);
            // 
            // msFileOpen
            // 
            this.msFileOpen.Name = "msFileOpen";
            this.msFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.msFileOpen.Size = new System.Drawing.Size(224, 26);
            this.msFileOpen.Text = "&Open";
            this.msFileOpen.ToolTipText = "This opens any text files";
            this.msFileOpen.Click += new System.EventHandler(this.msFileOpen_Click);
            // 
            // msFileSave
            // 
            this.msFileSave.Name = "msFileSave";
            this.msFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.msFileSave.Size = new System.Drawing.Size(224, 26);
            this.msFileSave.Text = "&Save";
            this.msFileSave.ToolTipText = "This saves any text entry into a text file";
            this.msFileSave.Click += new System.EventHandler(this.msFileSave_Click);
            // 
            // msFileSaveAs
            // 
            this.msFileSaveAs.Name = "msFileSaveAs";
            this.msFileSaveAs.Size = new System.Drawing.Size(224, 26);
            this.msFileSaveAs.Text = "S&ave As";
            this.msFileSaveAs.ToolTipText = "This saves any text entry into a text file";
            this.msFileSaveAs.Click += new System.EventHandler(this.msFileSaveAs_Click);
            // 
            // msFileClose
            // 
            this.msFileClose.Name = "msFileClose";
            this.msFileClose.Size = new System.Drawing.Size(224, 26);
            this.msFileClose.Text = "&Close";
            this.msFileClose.ToolTipText = "This closes any chlid forms";
            this.msFileClose.Click += new System.EventHandler(this.msFileClose_Click);
            // 
            // msFileExit
            // 
            this.msFileExit.Name = "msFileExit";
            this.msFileExit.Size = new System.Drawing.Size(224, 26);
            this.msFileExit.Text = "&Exit";
            this.msFileExit.ToolTipText = "This exits the whole program";
            this.msFileExit.Click += new System.EventHandler(this.msFileExit_Click);
            // 
            // msEdit
            // 
            this.msEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msEditCut,
            this.msEditCopy,
            this.msEditPaste,
            this.msEditSelectAll});
            this.msEdit.Name = "msEdit";
            this.msEdit.Size = new System.Drawing.Size(49, 24);
            this.msEdit.Text = "&Edit";
            this.msEdit.ToolTipText = "Edit tab this tab contains a cut, copy, paste and select all feature";
            // 
            // msEditCut
            // 
            this.msEditCut.Name = "msEditCut";
            this.msEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.msEditCut.Size = new System.Drawing.Size(224, 26);
            this.msEditCut.Text = "Cu&t";
            this.msEditCut.ToolTipText = "This cuts any text into the clipboard";
            this.msEditCut.Click += new System.EventHandler(this.msEditCut_Click);
            // 
            // msEditCopy
            // 
            this.msEditCopy.Name = "msEditCopy";
            this.msEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.msEditCopy.Size = new System.Drawing.Size(224, 26);
            this.msEditCopy.Text = "&Copy";
            this.msEditCopy.ToolTipText = "This copies any text into the clipboard";
            this.msEditCopy.Click += new System.EventHandler(this.msEditCopy_Click);
            // 
            // msEditPaste
            // 
            this.msEditPaste.Name = "msEditPaste";
            this.msEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.msEditPaste.Size = new System.Drawing.Size(224, 26);
            this.msEditPaste.Text = "&Paste";
            this.msEditPaste.ToolTipText = "This pastes anything from your clipboard into a textbox";
            this.msEditPaste.Click += new System.EventHandler(this.msEditPaste_Click);
            // 
            // msEditSelectAll
            // 
            this.msEditSelectAll.Name = "msEditSelectAll";
            this.msEditSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.msEditSelectAll.Size = new System.Drawing.Size(224, 26);
            this.msEditSelectAll.Text = "&Select All";
            this.msEditSelectAll.ToolTipText = "This selects all the text in the textbox that you are in";
            this.msEditSelectAll.Click += new System.EventHandler(this.msEditSelectAll_Click);
            // 
            // msWindow
            // 
            this.msWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msWindowCascade,
            this.msWindowTileVertical,
            this.msWindowTileHorizontal,
            this.msWindowWeeklyCases,
            this.msWindowContactTracer,
            this.msWindowOpenGPA,
            this.msWindowTextEditor,
            this.msWindowOpenICE01,
            this.msWindowOpenICE04,
            this.msWindowOpenICE05});
            this.msWindow.Name = "msWindow";
            this.msWindow.Size = new System.Drawing.Size(78, 24);
            this.msWindow.Text = "&Window";
            this.msWindow.ToolTipText = "Window tab this tab contains features to change how the windows organizes and ope" +
    "ns labs and ICES";
            // 
            // msWindowCascade
            // 
            this.msWindowCascade.Name = "msWindowCascade";
            this.msWindowCascade.Size = new System.Drawing.Size(230, 26);
            this.msWindowCascade.Text = "&Cascade";
            this.msWindowCascade.ToolTipText = "Makes the windows into cascade";
            this.msWindowCascade.Click += new System.EventHandler(this.msWindowCascade_Click);
            // 
            // msWindowTileVertical
            // 
            this.msWindowTileVertical.Name = "msWindowTileVertical";
            this.msWindowTileVertical.Size = new System.Drawing.Size(230, 26);
            this.msWindowTileVertical.Text = "&Tile Vertical";
            this.msWindowTileVertical.ToolTipText = "This makes the windows into vertical";
            this.msWindowTileVertical.Click += new System.EventHandler(this.msWindowTileVertical_Click);
            // 
            // msWindowTileHorizontal
            // 
            this.msWindowTileHorizontal.Name = "msWindowTileHorizontal";
            this.msWindowTileHorizontal.Size = new System.Drawing.Size(230, 26);
            this.msWindowTileHorizontal.Text = "T&ile Horizontal";
            this.msWindowTileHorizontal.ToolTipText = "This makes the windows into horizontal";
            this.msWindowTileHorizontal.Click += new System.EventHandler(this.msWindowTileHorizontal_Click);
            // 
            // msWindowWeeklyCases
            // 
            this.msWindowWeeklyCases.Name = "msWindowWeeklyCases";
            this.msWindowWeeklyCases.Size = new System.Drawing.Size(230, 26);
            this.msWindowWeeklyCases.Text = "&Open Weekly Cases";
            this.msWindowWeeklyCases.ToolTipText = "This opens the weekly cases form";
            this.msWindowWeeklyCases.Click += new System.EventHandler(this.msWindowWeeklyCases_Click);
            // 
            // msWindowContactTracer
            // 
            this.msWindowContactTracer.Name = "msWindowContactTracer";
            this.msWindowContactTracer.Size = new System.Drawing.Size(230, 26);
            this.msWindowContactTracer.Text = "Open Contact T&racer";
            this.msWindowContactTracer.ToolTipText = "This opens the contact tracer form";
            this.msWindowContactTracer.Click += new System.EventHandler(this.msWindowContactTracer_Click);
            // 
            // msWindowOpenGPA
            // 
            this.msWindowOpenGPA.Name = "msWindowOpenGPA";
            this.msWindowOpenGPA.Size = new System.Drawing.Size(230, 26);
            this.msWindowOpenGPA.Text = "Open &GPA Calculator";
            this.msWindowOpenGPA.ToolTipText = "This opens the GPA calculator form";
            this.msWindowOpenGPA.Click += new System.EventHandler(this.openGPACalculatorToolStripMenuItem_Click);
            // 
            // msWindowTextEditor
            // 
            this.msWindowTextEditor.Name = "msWindowTextEditor";
            this.msWindowTextEditor.Size = new System.Drawing.Size(230, 26);
            this.msWindowTextEditor.Text = "Open Te&xt Editor";
            this.msWindowTextEditor.ToolTipText = "This opens the text editor form";
            this.msWindowTextEditor.Click += new System.EventHandler(this.msWindowTextEditor_Click);
            // 
            // msWindowOpenICE01
            // 
            this.msWindowOpenICE01.Name = "msWindowOpenICE01";
            this.msWindowOpenICE01.Size = new System.Drawing.Size(230, 26);
            this.msWindowOpenICE01.Text = "O&pen ICE01";
            this.msWindowOpenICE01.ToolTipText = "This opens ICE01";
            this.msWindowOpenICE01.Click += new System.EventHandler(this.msWindowOpenICE01_Click);
            // 
            // msWindowOpenICE04
            // 
            this.msWindowOpenICE04.Name = "msWindowOpenICE04";
            this.msWindowOpenICE04.Size = new System.Drawing.Size(230, 26);
            this.msWindowOpenICE04.Text = "Op&en ICE04";
            this.msWindowOpenICE04.ToolTipText = "This opens ICE04";
            this.msWindowOpenICE04.Click += new System.EventHandler(this.msWindowOpenICE04_Click);
            // 
            // msWindowOpenICE05
            // 
            this.msWindowOpenICE05.Name = "msWindowOpenICE05";
            this.msWindowOpenICE05.Size = new System.Drawing.Size(230, 26);
            this.msWindowOpenICE05.Text = "Ope&n ICE05";
            this.msWindowOpenICE05.ToolTipText = "This opens ICE05";
            this.msWindowOpenICE05.Click += new System.EventHandler(this.msWindowOpenICE05_Click);
            // 
            // msHelp
            // 
            this.msHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msHelpAbout});
            this.msHelp.Name = "msHelp";
            this.msHelp.Size = new System.Drawing.Size(55, 24);
            this.msHelp.Text = "&Help";
            this.msHelp.ToolTipText = "Help tab this tab contains an about tab";
            // 
            // msHelpAbout
            // 
            this.msHelpAbout.Name = "msHelpAbout";
            this.msHelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.msHelpAbout.Size = new System.Drawing.Size(224, 26);
            this.msHelpAbout.Text = "&About";
            this.msHelpAbout.ToolTipText = "This tooltip is for about final project";
            this.msHelpAbout.Click += new System.EventHandler(this.msHelpAbout_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text Files|*.txt";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NETD 2202 - Infection Tool";
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem msFile;
        private System.Windows.Forms.ToolStripMenuItem msEdit;
        private System.Windows.Forms.ToolStripMenuItem msWindow;
        private System.Windows.Forms.ToolStripMenuItem msHelp;
        private System.Windows.Forms.ToolStripMenuItem msFileNew;
        private System.Windows.Forms.ToolStripMenuItem msFileOpen;
        private System.Windows.Forms.ToolStripMenuItem msFileSave;
        private System.Windows.Forms.ToolStripMenuItem msFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem msFileClose;
        private System.Windows.Forms.ToolStripMenuItem msFileExit;
        private System.Windows.Forms.ToolStripMenuItem msEditCut;
        private System.Windows.Forms.ToolStripMenuItem msEditCopy;
        private System.Windows.Forms.ToolStripMenuItem msEditPaste;
        private System.Windows.Forms.ToolStripMenuItem msEditSelectAll;
        private System.Windows.Forms.ToolStripMenuItem msHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem msWindowCascade;
        private System.Windows.Forms.ToolStripMenuItem msWindowTileVertical;
        private System.Windows.Forms.ToolStripMenuItem msWindowTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem msWindowWeeklyCases;
        private System.Windows.Forms.ToolStripMenuItem msWindowContactTracer;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem msWindowOpenGPA;
        private System.Windows.Forms.ToolStripMenuItem msWindowOpenICE01;
        private System.Windows.Forms.ToolStripMenuItem msWindowOpenICE04;
        private System.Windows.Forms.ToolStripMenuItem msWindowOpenICE05;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem msWindowTextEditor;
    }
}

