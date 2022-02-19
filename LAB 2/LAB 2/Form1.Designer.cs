
namespace LAB_2
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCourse1 = new System.Windows.Forms.TextBox();
            this.txtCourse4 = new System.Windows.Forms.TextBox();
            this.txtCourse6 = new System.Windows.Forms.TextBox();
            this.txtCourse5 = new System.Windows.Forms.TextBox();
            this.txtCourse2 = new System.Windows.Forms.TextBox();
            this.txtCourse7 = new System.Windows.Forms.TextBox();
            this.txtCourse3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSemNum = new System.Windows.Forms.TextBox();
            this.txtError = new System.Windows.Forms.TextBox();
            this.lblCourse1 = new System.Windows.Forms.Label();
            this.lblCourse2 = new System.Windows.Forms.Label();
            this.lblCourse3 = new System.Windows.Forms.Label();
            this.lblCourse4 = new System.Windows.Forms.Label();
            this.lblCourse5 = new System.Windows.Forms.Label();
            this.lblCourse6 = new System.Windows.Forms.Label();
            this.lblCourse7 = new System.Windows.Forms.Label();
            this.lblSem = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(25, 524);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.toolTip1.SetToolTip(this.btnCalculate, "Calculate grades for the semester");
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(169, 524);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(81, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.toolTip1.SetToolTip(this.btnReset, "Reset the form");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(325, 524);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.btnExit, "Exit the program");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Course 1:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(25, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Course 2:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(25, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Course 3:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(25, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Course 4:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(25, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Course 5:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(25, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Course 6:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(25, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Course 7:";
            // 
            // txtCourse1
            // 
            this.txtCourse1.Location = new System.Drawing.Point(169, 24);
            this.txtCourse1.Name = "txtCourse1";
            this.txtCourse1.Size = new System.Drawing.Size(81, 23);
            this.txtCourse1.TabIndex = 10;
            this.txtCourse1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtCourse1, "Grade for Course 1");
            this.txtCourse1.TextChanged += new System.EventHandler(this.txtCourse1_TextChanged);
            this.txtCourse1.Leave += new System.EventHandler(this.txtCourse1_Leave);
            // 
            // txtCourse4
            // 
            this.txtCourse4.Location = new System.Drawing.Point(169, 162);
            this.txtCourse4.Name = "txtCourse4";
            this.txtCourse4.Size = new System.Drawing.Size(81, 23);
            this.txtCourse4.TabIndex = 11;
            this.txtCourse4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtCourse4, "Grade for Course 4");
            this.txtCourse4.TextChanged += new System.EventHandler(this.txtCourse4_TextChanged);
            // 
            // txtCourse6
            // 
            this.txtCourse6.Location = new System.Drawing.Point(169, 254);
            this.txtCourse6.Name = "txtCourse6";
            this.txtCourse6.Size = new System.Drawing.Size(81, 23);
            this.txtCourse6.TabIndex = 12;
            this.txtCourse6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtCourse6, "Grade for Course 6");
            this.txtCourse6.TextChanged += new System.EventHandler(this.txtCourse6_TextChanged);
            // 
            // txtCourse5
            // 
            this.txtCourse5.Location = new System.Drawing.Point(169, 208);
            this.txtCourse5.Name = "txtCourse5";
            this.txtCourse5.Size = new System.Drawing.Size(81, 23);
            this.txtCourse5.TabIndex = 13;
            this.txtCourse5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtCourse5, "Grade for Course 5");
            this.txtCourse5.TextChanged += new System.EventHandler(this.txtCourse5_TextChanged);
            // 
            // txtCourse2
            // 
            this.txtCourse2.Location = new System.Drawing.Point(169, 70);
            this.txtCourse2.Name = "txtCourse2";
            this.txtCourse2.Size = new System.Drawing.Size(81, 23);
            this.txtCourse2.TabIndex = 14;
            this.txtCourse2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtCourse2, "Grade for Course 2");
            this.txtCourse2.TextChanged += new System.EventHandler(this.txtCourse2_TextChanged);
            // 
            // txtCourse7
            // 
            this.txtCourse7.Location = new System.Drawing.Point(169, 300);
            this.txtCourse7.Name = "txtCourse7";
            this.txtCourse7.Size = new System.Drawing.Size(81, 23);
            this.txtCourse7.TabIndex = 15;
            this.txtCourse7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtCourse7, "Grade for Course 7");
            this.txtCourse7.TextChanged += new System.EventHandler(this.txtCourse7_TextChanged);
            // 
            // txtCourse3
            // 
            this.txtCourse3.Location = new System.Drawing.Point(169, 116);
            this.txtCourse3.Name = "txtCourse3";
            this.txtCourse3.Size = new System.Drawing.Size(81, 23);
            this.txtCourse3.TabIndex = 16;
            this.txtCourse3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtCourse3, "Grade for Course 3");
            this.txtCourse3.TextChanged += new System.EventHandler(this.txtCourse3_TextChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(25, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Semester:";
            // 
            // txtSemNum
            // 
            this.txtSemNum.Location = new System.Drawing.Point(169, 346);
            this.txtSemNum.Name = "txtSemNum";
            this.txtSemNum.ReadOnly = true;
            this.txtSemNum.Size = new System.Drawing.Size(81, 23);
            this.txtSemNum.TabIndex = 18;
            this.txtSemNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtSemNum, "Grade for the Semester");
            this.txtSemNum.TextChanged += new System.EventHandler(this.txtSemNum_TextChanged);
            // 
            // txtError
            // 
            this.txtError.Location = new System.Drawing.Point(25, 393);
            this.txtError.Multiline = true;
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.Size = new System.Drawing.Size(375, 112);
            this.txtError.TabIndex = 27;
            this.txtError.Text = " ";
            this.toolTip1.SetToolTip(this.txtError, "Error Label");
            this.txtError.TextChanged += new System.EventHandler(this.txtError_TextChanged);
            // 
            // lblCourse1
            // 
            this.lblCourse1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCourse1.Location = new System.Drawing.Point(325, 24);
            this.lblCourse1.Name = "lblCourse1";
            this.lblCourse1.Size = new System.Drawing.Size(75, 23);
            this.lblCourse1.TabIndex = 28;
            this.lblCourse1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblCourse1, "Grade in letter for course 1");
            // 
            // lblCourse2
            // 
            this.lblCourse2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCourse2.Location = new System.Drawing.Point(325, 73);
            this.lblCourse2.Name = "lblCourse2";
            this.lblCourse2.Size = new System.Drawing.Size(75, 23);
            this.lblCourse2.TabIndex = 29;
            this.lblCourse2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblCourse2, "Grade in letter for course 2");
            // 
            // lblCourse3
            // 
            this.lblCourse3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCourse3.Location = new System.Drawing.Point(325, 119);
            this.lblCourse3.Name = "lblCourse3";
            this.lblCourse3.Size = new System.Drawing.Size(75, 23);
            this.lblCourse3.TabIndex = 30;
            this.lblCourse3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblCourse3, "Grade in letter for course 3");
            // 
            // lblCourse4
            // 
            this.lblCourse4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCourse4.Location = new System.Drawing.Point(325, 162);
            this.lblCourse4.Name = "lblCourse4";
            this.lblCourse4.Size = new System.Drawing.Size(75, 23);
            this.lblCourse4.TabIndex = 31;
            this.lblCourse4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblCourse4, "Grade in letter for course 4");
            // 
            // lblCourse5
            // 
            this.lblCourse5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCourse5.Location = new System.Drawing.Point(325, 208);
            this.lblCourse5.Name = "lblCourse5";
            this.lblCourse5.Size = new System.Drawing.Size(75, 23);
            this.lblCourse5.TabIndex = 32;
            this.lblCourse5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblCourse5, "Grade in letter for course 5");
            // 
            // lblCourse6
            // 
            this.lblCourse6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCourse6.Location = new System.Drawing.Point(325, 254);
            this.lblCourse6.Name = "lblCourse6";
            this.lblCourse6.Size = new System.Drawing.Size(75, 23);
            this.lblCourse6.TabIndex = 33;
            this.lblCourse6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblCourse6, "Grade in letter for course 6");
            // 
            // lblCourse7
            // 
            this.lblCourse7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCourse7.Location = new System.Drawing.Point(325, 300);
            this.lblCourse7.Name = "lblCourse7";
            this.lblCourse7.Size = new System.Drawing.Size(75, 23);
            this.lblCourse7.TabIndex = 34;
            this.lblCourse7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblCourse7, "Grade in letter for course 7");
            // 
            // lblSem
            // 
            this.lblSem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSem.Location = new System.Drawing.Point(325, 346);
            this.lblSem.Name = "lblSem";
            this.lblSem.Size = new System.Drawing.Size(75, 23);
            this.lblSem.TabIndex = 35;
            this.lblSem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblSem, "Grade in letter for the semester");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 580);
            this.Controls.Add(this.lblSem);
            this.Controls.Add(this.lblCourse7);
            this.Controls.Add(this.lblCourse6);
            this.Controls.Add(this.lblCourse5);
            this.Controls.Add(this.lblCourse4);
            this.Controls.Add(this.lblCourse3);
            this.Controls.Add(this.lblCourse2);
            this.Controls.Add(this.lblCourse1);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.txtSemNum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCourse3);
            this.Controls.Add(this.txtCourse7);
            this.Controls.Add(this.txtCourse2);
            this.Controls.Add(this.txtCourse5);
            this.Controls.Add(this.txtCourse6);
            this.Controls.Add(this.txtCourse4);
            this.Controls.Add(this.txtCourse1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Nguyen Duc - Semester Grades";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCourse1;
        private System.Windows.Forms.TextBox txtCourse4;
        private System.Windows.Forms.TextBox txtCourse6;
        private System.Windows.Forms.TextBox txtCourse5;
        private System.Windows.Forms.TextBox txtCourse2;
        private System.Windows.Forms.TextBox txtCourse7;
        private System.Windows.Forms.TextBox txtCourse3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSemNum;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.Label lblCourse1;
        private System.Windows.Forms.Label lblCourse2;
        private System.Windows.Forms.Label lblCourse3;
        private System.Windows.Forms.Label lblCourse4;
        private System.Windows.Forms.Label lblCourse5;
        private System.Windows.Forms.Label lblCourse6;
        private System.Windows.Forms.Label lblCourse7;
        private System.Windows.Forms.Label lblSem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

