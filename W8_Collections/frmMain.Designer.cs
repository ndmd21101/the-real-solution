﻿
namespace PPProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dgvClones = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkDefective = new System.Windows.Forms.CheckBox();
            this.btnSetEyeColour = new System.Windows.Forms.Button();
            this.lblEyeColour = new System.Windows.Forms.Label();
            this.lblSecondColourLabel = new System.Windows.Forms.Label();
            this.btnSetHairColour = new System.Windows.Forms.Button();
            this.lblHairColour = new System.Windows.Forms.Label();
            this.lblColour1Label = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.dtpBorn = new System.Windows.Forms.DateTimePicker();
            this.lblBorn = new System.Windows.Forms.Label();
            this.cboPlanets = new System.Windows.Forms.ComboBox();
            this.lblHomeWorld = new System.Windows.Forms.Label();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.lblNickName = new System.Windows.Forms.Label();
            this.nudDesignation = new System.Windows.Forms.NumericUpDown();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblTitleBar = new System.Windows.Forms.Label();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colPrimaryColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSecondaryColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClones)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesignation)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClones
            // 
            this.dgvClones.AllowUserToAddRows = false;
            this.dgvClones.AllowUserToDeleteRows = false;
            this.dgvClones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClones.BackgroundColor = System.Drawing.Color.Black;
            this.dgvClones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
            this.colProductCategory,
            this.colProductName,
            this.colMade,
            this.colSize,
            this.colStock,
            this.colPrimaryColor,
            this.colSecondaryColor});
            this.dgvClones.Location = new System.Drawing.Point(12, 39);
            this.dgvClones.MultiSelect = false;
            this.dgvClones.Name = "dgvClones";
            this.dgvClones.ReadOnly = true;
            this.dgvClones.RowHeadersVisible = false;
            this.dgvClones.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.dgvClones.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvClones.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvClones.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(0)))));
            this.dgvClones.RowTemplate.Height = 25;
            this.dgvClones.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClones.ShowEditingIcon = false;
            this.dgvClones.Size = new System.Drawing.Size(878, 222);
            this.dgvClones.TabIndex = 1;
            this.dgvClones.VirtualMode = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.chkDefective);
            this.groupBox1.Controls.Add(this.btnSetEyeColour);
            this.groupBox1.Controls.Add(this.lblEyeColour);
            this.groupBox1.Controls.Add(this.lblSecondColourLabel);
            this.groupBox1.Controls.Add(this.btnSetHairColour);
            this.groupBox1.Controls.Add(this.lblHairColour);
            this.groupBox1.Controls.Add(this.lblColour1Label);
            this.groupBox1.Controls.Add(this.txtUnit);
            this.groupBox1.Controls.Add(this.lblUnit);
            this.groupBox1.Controls.Add(this.dtpBorn);
            this.groupBox1.Controls.Add(this.lblBorn);
            this.groupBox1.Controls.Add(this.cboPlanets);
            this.groupBox1.Controls.Add(this.lblHomeWorld);
            this.groupBox1.Controls.Add(this.txtNickName);
            this.groupBox1.Controls.Add(this.lblNickName);
            this.groupBox1.Controls.Add(this.nudDesignation);
            this.groupBox1.Controls.Add(this.lblDesignation);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 254);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit";
            // 
            // btnReset
            // 
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(285, 204);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 43);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(366, 204);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 43);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkDefective
            // 
            this.chkDefective.AutoSize = true;
            this.chkDefective.Location = new System.Drawing.Point(103, 217);
            this.chkDefective.Name = "chkDefective";
            this.chkDefective.Size = new System.Drawing.Size(68, 19);
            this.chkDefective.TabIndex = 17;
            this.chkDefective.Text = "In Stock";
            this.chkDefective.UseVisualStyleBackColor = true;
            // 
            // btnSetEyeColour
            // 
            this.btnSetEyeColour.ForeColor = System.Drawing.Color.Black;
            this.btnSetEyeColour.Location = new System.Drawing.Point(385, 63);
            this.btnSetEyeColour.Name = "btnSetEyeColour";
            this.btnSetEyeColour.Size = new System.Drawing.Size(45, 38);
            this.btnSetEyeColour.TabIndex = 16;
            this.btnSetEyeColour.Text = "Set";
            this.btnSetEyeColour.UseVisualStyleBackColor = true;
            this.btnSetEyeColour.Click += new System.EventHandler(this.btnSetEyeColour_Click);
            // 
            // lblEyeColour
            // 
            this.lblEyeColour.BackColor = System.Drawing.Color.Gray;
            this.lblEyeColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEyeColour.Location = new System.Drawing.Point(335, 63);
            this.lblEyeColour.Name = "lblEyeColour";
            this.lblEyeColour.Size = new System.Drawing.Size(43, 38);
            this.lblEyeColour.TabIndex = 15;
            // 
            // lblSecondColourLabel
            // 
            this.lblSecondColourLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSecondColourLabel.Location = new System.Drawing.Point(251, 63);
            this.lblSecondColourLabel.Name = "lblSecondColourLabel";
            this.lblSecondColourLabel.Size = new System.Drawing.Size(78, 38);
            this.lblSecondColourLabel.TabIndex = 14;
            this.lblSecondColourLabel.Text = "Secondary Color";
            this.lblSecondColourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSetHairColour
            // 
            this.btnSetHairColour.ForeColor = System.Drawing.Color.Black;
            this.btnSetHairColour.Location = new System.Drawing.Point(385, 19);
            this.btnSetHairColour.Name = "btnSetHairColour";
            this.btnSetHairColour.Size = new System.Drawing.Size(45, 38);
            this.btnSetHairColour.TabIndex = 13;
            this.btnSetHairColour.Text = "Set";
            this.btnSetHairColour.UseVisualStyleBackColor = true;
            this.btnSetHairColour.Click += new System.EventHandler(this.btnSetHairColour_Click);
            // 
            // lblHairColour
            // 
            this.lblHairColour.BackColor = System.Drawing.Color.Gray;
            this.lblHairColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHairColour.Location = new System.Drawing.Point(335, 19);
            this.lblHairColour.Name = "lblHairColour";
            this.lblHairColour.Size = new System.Drawing.Size(43, 38);
            this.lblHairColour.TabIndex = 12;
            // 
            // lblColour1Label
            // 
            this.lblColour1Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblColour1Label.Location = new System.Drawing.Point(251, 19);
            this.lblColour1Label.Name = "lblColour1Label";
            this.lblColour1Label.Size = new System.Drawing.Size(76, 38);
            this.lblColour1Label.TabIndex = 11;
            this.lblColour1Label.Text = "Primary Color";
            this.lblColour1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(125, 173);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(100, 23);
            this.txtUnit.TabIndex = 9;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(21, 177);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(27, 15);
            this.lblUnit.TabIndex = 8;
            this.lblUnit.Text = "Size";
            // 
            // dtpBorn
            // 
            this.dtpBorn.Location = new System.Drawing.Point(125, 132);
            this.dtpBorn.Name = "dtpBorn";
            this.dtpBorn.Size = new System.Drawing.Size(163, 23);
            this.dtpBorn.TabIndex = 7;
            this.dtpBorn.ValueChanged += new System.EventHandler(this.dtpBorn_ValueChanged);
            // 
            // lblBorn
            // 
            this.lblBorn.AutoSize = true;
            this.lblBorn.Location = new System.Drawing.Point(21, 139);
            this.lblBorn.Name = "lblBorn";
            this.lblBorn.Size = new System.Drawing.Size(37, 15);
            this.lblBorn.TabIndex = 6;
            this.lblBorn.Text = "Made";
            // 
            // cboPlanets
            // 
            this.cboPlanets.FormattingEnabled = true;
            this.cboPlanets.Location = new System.Drawing.Point(125, 97);
            this.cboPlanets.Name = "cboPlanets";
            this.cboPlanets.Size = new System.Drawing.Size(121, 23);
            this.cboPlanets.TabIndex = 5;
            this.cboPlanets.SelectedIndexChanged += new System.EventHandler(this.cboPlanets_SelectedIndexChanged);
            // 
            // lblHomeWorld
            // 
            this.lblHomeWorld.AutoSize = true;
            this.lblHomeWorld.Location = new System.Drawing.Point(21, 101);
            this.lblHomeWorld.Name = "lblHomeWorld";
            this.lblHomeWorld.Size = new System.Drawing.Size(38, 15);
            this.lblHomeWorld.TabIndex = 4;
            this.lblHomeWorld.Text = "Brand";
            // 
            // txtNickName
            // 
            this.txtNickName.Location = new System.Drawing.Point(125, 59);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(100, 23);
            this.txtNickName.TabIndex = 3;
            // 
            // lblNickName
            // 
            this.lblNickName.AutoSize = true;
            this.lblNickName.Location = new System.Drawing.Point(21, 63);
            this.lblNickName.Name = "lblNickName";
            this.lblNickName.Size = new System.Drawing.Size(100, 15);
            this.lblNickName.TabIndex = 2;
            this.lblNickName.Text = "Product Category";
            // 
            // nudDesignation
            // 
            this.nudDesignation.Location = new System.Drawing.Point(125, 22);
            this.nudDesignation.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudDesignation.Name = "nudDesignation";
            this.nudDesignation.Size = new System.Drawing.Size(85, 23);
            this.nudDesignation.TabIndex = 1;
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(21, 25);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(85, 15);
            this.lblDesignation.TabIndex = 0;
            this.lblDesignation.Text = "Items Quantity";
            // 
            // lblTitleBar
            // 
            this.lblTitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitleBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitleBar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleBar.ForeColor = System.Drawing.Color.Black;
            this.lblTitleBar.Location = new System.Drawing.Point(1, 1);
            this.lblTitleBar.Name = "lblTitleBar";
            this.lblTitleBar.Size = new System.Drawing.Size(933, 35);
            this.lblTitleBar.TabIndex = 3;
            this.lblTitleBar.Text = "Managing Products";
            this.lblTitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colCode
            // 
            this.colCode.DataPropertyName = "ItemsCode";
            this.colCode.HeaderText = "Items Quantity";
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            this.colCode.Width = 120;
            // 
            // colProductCategory
            // 
            this.colProductCategory.DataPropertyName = "ProductCategory";
            this.colProductCategory.HeaderText = "Product Category";
            this.colProductCategory.Name = "colProductCategory";
            this.colProductCategory.ReadOnly = true;
            this.colProductCategory.Width = 150;
            // 
            // colProductName
            // 
            this.colProductName.DataPropertyName = "ProductName";
            this.colProductName.HeaderText = "Product Name";
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            this.colProductName.Width = 120;
            // 
            // colMade
            // 
            this.colMade.DataPropertyName = "Made";
            this.colMade.HeaderText = "Made";
            this.colMade.Name = "colMade";
            this.colMade.ReadOnly = true;
            this.colMade.Width = 75;
            // 
            // colSize
            // 
            this.colSize.DataPropertyName = "Size";
            this.colSize.HeaderText = "Size";
            this.colSize.Name = "colSize";
            this.colSize.ReadOnly = true;
            this.colSize.Width = 75;
            // 
            // colStock
            // 
            this.colStock.DataPropertyName = "IsInStock";
            this.colStock.HeaderText = "In Stock";
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            this.colStock.Width = 80;
            // 
            // colPrimaryColor
            // 
            this.colPrimaryColor.DataPropertyName = "PrimaryColor";
            this.colPrimaryColor.HeaderText = "Primary Color";
            this.colPrimaryColor.Name = "colPrimaryColor";
            this.colPrimaryColor.ReadOnly = true;
            this.colPrimaryColor.Width = 120;
            // 
            // colSecondaryColor
            // 
            this.colSecondaryColor.DataPropertyName = "SecondaryColor";
            this.colSecondaryColor.HeaderText = "Secondary Color";
            this.colSecondaryColor.Name = "colSecondaryColor";
            this.colSecondaryColor.ReadOnly = true;
            this.colSecondaryColor.Width = 120;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(935, 558);
            this.Controls.Add(this.lblTitleBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvClones);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Droid Factory";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesignation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvClones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboPlanets;
        private System.Windows.Forms.Label lblHomeWorld;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.Label lblNickName;
        private System.Windows.Forms.NumericUpDown nudDesignation;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.DateTimePicker dtpBorn;
        private System.Windows.Forms.Label lblBorn;
        private System.Windows.Forms.Button btnSetEyeColour;
        private System.Windows.Forms.Label lblEyeColour;
        private System.Windows.Forms.Label lblSecondColourLabel;
        private System.Windows.Forms.Button btnSetHairColour;
        private System.Windows.Forms.Label lblHairColour;
        private System.Windows.Forms.Label lblColour1Label;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkDefective;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblTitleBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrimaryColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSecondaryColor;
    }
}

