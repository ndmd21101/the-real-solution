
namespace LAB_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCases = new System.Windows.Forms.TextBox();
            this.lstRegion1 = new System.Windows.Forms.ListBox();
            this.lblAvgRegion1 = new System.Windows.Forms.Label();
            this.lblRegion1 = new System.Windows.Forms.Label();
            this.lstRegion2 = new System.Windows.Forms.ListBox();
            this.lblRegion2 = new System.Windows.Forms.Label();
            this.lblRegion3 = new System.Windows.Forms.Label();
            this.lstRegion3 = new System.Windows.Forms.ListBox();
            this.lblAvgRegion2 = new System.Windows.Forms.Label();
            this.lblAvgRegion3 = new System.Windows.Forms.Label();
            this.lblTotalAvg = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cases: ";
            // 
            // txtCases
            // 
            this.txtCases.Location = new System.Drawing.Point(88, 38);
            this.txtCases.Name = "txtCases";
            this.txtCases.Size = new System.Drawing.Size(100, 23);
            this.txtCases.TabIndex = 1;
            // 
            // lstRegion1
            // 
            this.lstRegion1.FormattingEnabled = true;
            this.lstRegion1.ItemHeight = 15;
            this.lstRegion1.Location = new System.Drawing.Point(31, 134);
            this.lstRegion1.Name = "lstRegion1";
            this.lstRegion1.Size = new System.Drawing.Size(139, 229);
            this.lstRegion1.TabIndex = 2;
            // 
            // lblAvgRegion1
            // 
            this.lblAvgRegion1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAvgRegion1.Location = new System.Drawing.Point(12, 388);
            this.lblAvgRegion1.Name = "lblAvgRegion1";
            this.lblAvgRegion1.Size = new System.Drawing.Size(176, 41);
            this.lblAvgRegion1.TabIndex = 3;
            this.lblAvgRegion1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRegion1
            // 
            this.lblRegion1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegion1.Location = new System.Drawing.Point(51, 86);
            this.lblRegion1.Name = "lblRegion1";
            this.lblRegion1.Size = new System.Drawing.Size(100, 23);
            this.lblRegion1.TabIndex = 4;
            this.lblRegion1.Text = "Region 1";
            this.lblRegion1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstRegion2
            // 
            this.lstRegion2.FormattingEnabled = true;
            this.lstRegion2.ItemHeight = 15;
            this.lstRegion2.Location = new System.Drawing.Point(214, 134);
            this.lstRegion2.Name = "lstRegion2";
            this.lstRegion2.Size = new System.Drawing.Size(139, 229);
            this.lstRegion2.TabIndex = 5;
            // 
            // lblRegion2
            // 
            this.lblRegion2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegion2.Location = new System.Drawing.Point(233, 86);
            this.lblRegion2.Name = "lblRegion2";
            this.lblRegion2.Size = new System.Drawing.Size(100, 23);
            this.lblRegion2.TabIndex = 6;
            this.lblRegion2.Text = "Region 2";
            this.lblRegion2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRegion3
            // 
            this.lblRegion3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegion3.Location = new System.Drawing.Point(415, 86);
            this.lblRegion3.Name = "lblRegion3";
            this.lblRegion3.Size = new System.Drawing.Size(100, 23);
            this.lblRegion3.TabIndex = 8;
            this.lblRegion3.Text = "Region 3";
            this.lblRegion3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstRegion3
            // 
            this.lstRegion3.FormattingEnabled = true;
            this.lstRegion3.ItemHeight = 15;
            this.lstRegion3.Location = new System.Drawing.Point(397, 134);
            this.lstRegion3.Name = "lstRegion3";
            this.lstRegion3.Size = new System.Drawing.Size(139, 229);
            this.lstRegion3.TabIndex = 7;
            // 
            // lblAvgRegion2
            // 
            this.lblAvgRegion2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAvgRegion2.Location = new System.Drawing.Point(194, 388);
            this.lblAvgRegion2.Name = "lblAvgRegion2";
            this.lblAvgRegion2.Size = new System.Drawing.Size(176, 41);
            this.lblAvgRegion2.TabIndex = 9;
            this.lblAvgRegion2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvgRegion3
            // 
            this.lblAvgRegion3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAvgRegion3.Location = new System.Drawing.Point(376, 388);
            this.lblAvgRegion3.Name = "lblAvgRegion3";
            this.lblAvgRegion3.Size = new System.Drawing.Size(176, 41);
            this.lblAvgRegion3.TabIndex = 10;
            this.lblAvgRegion3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalAvg
            // 
            this.lblTotalAvg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalAvg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalAvg.Location = new System.Drawing.Point(12, 438);
            this.lblTotalAvg.Name = "lblTotalAvg";
            this.lblTotalAvg.Size = new System.Drawing.Size(540, 34);
            this.lblTotalAvg.TabIndex = 11;
            this.lblTotalAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnter.Location = new System.Drawing.Point(8, 495);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(180, 32);
            this.btnEnter.TabIndex = 14;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(194, 495);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(176, 32);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(376, 495);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(176, 32);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblTotalAvg);
            this.Controls.Add(this.lblAvgRegion3);
            this.Controls.Add(this.lblAvgRegion2);
            this.Controls.Add(this.lblRegion3);
            this.Controls.Add(this.lstRegion3);
            this.Controls.Add(this.lblRegion2);
            this.Controls.Add(this.lstRegion2);
            this.Controls.Add(this.lblRegion1);
            this.Controls.Add(this.lblAvgRegion1);
            this.Controls.Add(this.lstRegion1);
            this.Controls.Add(this.txtCases);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCases;
        private System.Windows.Forms.ListBox lstRegion1;
        private System.Windows.Forms.Label lblAvgRegion1;
        private System.Windows.Forms.Label lblRegion1;
        private System.Windows.Forms.ListBox lstRegion2;
        private System.Windows.Forms.Label lblRegion2;
        private System.Windows.Forms.Label lblRegion3;
        private System.Windows.Forms.ListBox lstRegion3;
        private System.Windows.Forms.Label lblAvgRegion2;
        private System.Windows.Forms.Label lblAvgRegion3;
        private System.Windows.Forms.Label lblTotalAvg;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}

