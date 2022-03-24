
namespace ICE_4
{
    partial class frmAddEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSecondaryColor = new System.Windows.Forms.Label();
            this.btnSecondaryColor = new System.Windows.Forms.Button();
            this.lblPrimaryColor = new System.Windows.Forms.Label();
            this.btnPrimaryColor = new System.Windows.Forms.Button();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSaveExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.btnSaveExit);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblSecondaryColor);
            this.groupBox1.Controls.Add(this.btnSecondaryColor);
            this.groupBox1.Controls.Add(this.lblPrimaryColor);
            this.groupBox1.Controls.Add(this.btnPrimaryColor);
            this.groupBox1.Controls.Add(this.cboSize);
            this.groupBox1.Controls.Add(this.nudQuantity);
            this.groupBox1.Controls.Add(this.cboCategory);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 277);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Items";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(201, 184);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 47);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(302, 184);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 47);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "&Save and Continue";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Secondary Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Primary Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Product Name";
            // 
            // lblSecondaryColor
            // 
            this.lblSecondaryColor.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblSecondaryColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSecondaryColor.Location = new System.Drawing.Point(384, 117);
            this.lblSecondaryColor.Name = "lblSecondaryColor";
            this.lblSecondaryColor.Size = new System.Drawing.Size(54, 45);
            this.lblSecondaryColor.TabIndex = 9;
            // 
            // btnSecondaryColor
            // 
            this.btnSecondaryColor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSecondaryColor.Location = new System.Drawing.Point(311, 117);
            this.btnSecondaryColor.Name = "btnSecondaryColor";
            this.btnSecondaryColor.Size = new System.Drawing.Size(51, 45);
            this.btnSecondaryColor.TabIndex = 8;
            this.btnSecondaryColor.Text = "Set";
            this.btnSecondaryColor.UseVisualStyleBackColor = true;
            // 
            // lblPrimaryColor
            // 
            this.lblPrimaryColor.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblPrimaryColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrimaryColor.Location = new System.Drawing.Point(384, 37);
            this.lblPrimaryColor.Name = "lblPrimaryColor";
            this.lblPrimaryColor.Size = new System.Drawing.Size(54, 45);
            this.lblPrimaryColor.TabIndex = 7;
            // 
            // btnPrimaryColor
            // 
            this.btnPrimaryColor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrimaryColor.Location = new System.Drawing.Point(311, 37);
            this.btnPrimaryColor.Name = "btnPrimaryColor";
            this.btnPrimaryColor.Size = new System.Drawing.Size(51, 45);
            this.btnPrimaryColor.TabIndex = 6;
            this.btnPrimaryColor.Text = "Set";
            this.btnPrimaryColor.UseVisualStyleBackColor = true;
            // 
            // cboSize
            // 
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Location = new System.Drawing.Point(98, 154);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(100, 23);
            this.cboSize.TabIndex = 5;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(98, 110);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(100, 23);
            this.nudQuantity.TabIndex = 4;
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(98, 66);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(100, 23);
            this.cboCategory.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(98, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 0;
            // 
            // btnSaveExit
            // 
            this.btnSaveExit.Location = new System.Drawing.Point(403, 184);
            this.btnSaveExit.Name = "btnSaveExit";
            this.btnSaveExit.Size = new System.Drawing.Size(92, 47);
            this.btnSaveExit.TabIndex = 17;
            this.btnSaveExit.Text = "Save and &Exit";
            this.btnSaveExit.UseVisualStyleBackColor = true;
            this.btnSaveExit.Click += new System.EventHandler(this.btnSaveExit_Click);
            // 
            // frmAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(583, 318);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAddEdit";
            this.Text = "frmAddEdit";
            this.Load += new System.EventHandler(this.frmAddEdit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSecondaryColor;
        private System.Windows.Forms.Button btnSecondaryColor;
        private System.Windows.Forms.Label lblPrimaryColor;
        private System.Windows.Forms.Button btnPrimaryColor;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.TextBox txtName;
    }
}