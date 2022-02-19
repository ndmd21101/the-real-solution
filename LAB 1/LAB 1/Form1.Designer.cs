
namespace LAB_1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCasesNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblOuput = new System.Windows.Forms.Label();
            this.lblCasesNumber = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cases:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCasesNumber
            // 
            this.txtCasesNumber.Location = new System.Drawing.Point(123, 31);
            this.txtCasesNumber.Name = "txtCasesNumber";
            this.txtCasesNumber.Size = new System.Drawing.Size(100, 23);
            this.txtCasesNumber.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtCasesNumber, "Enter the number of cases for today");
            this.txtCasesNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(247, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Day 1";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(46, 362);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 26);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "&Enter";
            this.toolTip1.SetToolTip(this.btnEnter, "Designate number of cases for each day");
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(135, 362);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 26);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.toolTip1.SetToolTip(this.btnReset, "Reset cases records");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(224, 362);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 26);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.btnExit, "Exit the program");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblOuput
            // 
            this.lblOuput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOuput.Location = new System.Drawing.Point(46, 312);
            this.lblOuput.Name = "lblOuput";
            this.lblOuput.Size = new System.Drawing.Size(253, 36);
            this.lblOuput.TabIndex = 4;
            this.lblOuput.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblCasesNumber
            // 
            this.lblCasesNumber.FormattingEnabled = true;
            this.lblCasesNumber.ItemHeight = 15;
            this.lblCasesNumber.Location = new System.Drawing.Point(46, 90);
            this.lblCasesNumber.Name = "lblCasesNumber";
            this.lblCasesNumber.Size = new System.Drawing.Size(253, 214);
            this.lblCasesNumber.TabIndex = 3;
            this.toolTip1.SetToolTip(this.lblCasesNumber, "Number of cases for everyday of the week");
            this.lblCasesNumber.SelectedIndexChanged += new System.EventHandler(this.lblCasesNumber_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(351, 400);
            this.Controls.Add(this.lblCasesNumber);
            this.Controls.Add(this.lblOuput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCasesNumber);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Weekly Cases";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCasesNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblOuput;
        private System.Windows.Forms.ListBox lblCasesNumber;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

