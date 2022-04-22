
namespace FinalProject
{
    partial class frmGPA
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
            this.lblCourse1 = new System.Windows.Forms.Label();
            this.lblCourse2 = new System.Windows.Forms.Label();
            this.lblCourse3 = new System.Windows.Forms.Label();
            this.lblCourse4 = new System.Windows.Forms.Label();
            this.lblCourse5 = new System.Windows.Forms.Label();
            this.lblCourse6 = new System.Windows.Forms.Label();
            this.lblCourse7 = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.tbxGrade1 = new System.Windows.Forms.TextBox();
            this.tbxGrade2 = new System.Windows.Forms.TextBox();
            this.tbxGrade3 = new System.Windows.Forms.TextBox();
            this.tbxGrade4 = new System.Windows.Forms.TextBox();
            this.tbxGrade5 = new System.Windows.Forms.TextBox();
            this.tbxGrade6 = new System.Windows.Forms.TextBox();
            this.tbxGrade7 = new System.Windows.Forms.TextBox();
            this.lblCourseFinal = new System.Windows.Forms.Label();
            this.lblLetter1 = new System.Windows.Forms.Label();
            this.lblLetter2 = new System.Windows.Forms.Label();
            this.lblLetter3 = new System.Windows.Forms.Label();
            this.lblLetter6 = new System.Windows.Forms.Label();
            this.lblLetter5 = new System.Windows.Forms.Label();
            this.lblLetter4 = new System.Windows.Forms.Label();
            this.lblLetter7 = new System.Windows.Forms.Label();
            this.lblLetterFinal = new System.Windows.Forms.Label();
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.Location = new System.Drawing.Point(11, 527);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(94, 29);
            this.btnCalculate.TabIndex = 20;
            this.btnCalculate.Text = "&Calculate";
            this.toolTip1.SetToolTip(this.btnCalculate, "This is the calculate button where it calculates your courses and finds the avera" +
        "ge");
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(135, 527);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 29);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "Re&set";
            this.toolTip1.SetToolTip(this.btnReset, "This button resets your application to default properties");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(259, 527);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "&Exit";
            this.toolTip1.SetToolTip(this.btnExit, "This button exits your program.");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCourse1
            // 
            this.lblCourse1.AutoSize = true;
            this.lblCourse1.Location = new System.Drawing.Point(11, 43);
            this.lblCourse1.Name = "lblCourse1";
            this.lblCourse1.Size = new System.Drawing.Size(69, 20);
            this.lblCourse1.TabIndex = 3;
            this.lblCourse1.Text = "Course 1:";
            // 
            // lblCourse2
            // 
            this.lblCourse2.AutoSize = true;
            this.lblCourse2.Location = new System.Drawing.Point(11, 85);
            this.lblCourse2.Name = "lblCourse2";
            this.lblCourse2.Size = new System.Drawing.Size(69, 20);
            this.lblCourse2.TabIndex = 4;
            this.lblCourse2.Text = "Course 2:";
            // 
            // lblCourse3
            // 
            this.lblCourse3.AutoSize = true;
            this.lblCourse3.Location = new System.Drawing.Point(11, 127);
            this.lblCourse3.Name = "lblCourse3";
            this.lblCourse3.Size = new System.Drawing.Size(69, 20);
            this.lblCourse3.TabIndex = 5;
            this.lblCourse3.Text = "Course 3:";
            // 
            // lblCourse4
            // 
            this.lblCourse4.AutoSize = true;
            this.lblCourse4.Location = new System.Drawing.Point(11, 168);
            this.lblCourse4.Name = "lblCourse4";
            this.lblCourse4.Size = new System.Drawing.Size(69, 20);
            this.lblCourse4.TabIndex = 6;
            this.lblCourse4.Text = "Course 4:";
            // 
            // lblCourse5
            // 
            this.lblCourse5.AutoSize = true;
            this.lblCourse5.Location = new System.Drawing.Point(11, 211);
            this.lblCourse5.Name = "lblCourse5";
            this.lblCourse5.Size = new System.Drawing.Size(69, 20);
            this.lblCourse5.TabIndex = 7;
            this.lblCourse5.Text = "Course 5:";
            // 
            // lblCourse6
            // 
            this.lblCourse6.AutoSize = true;
            this.lblCourse6.Location = new System.Drawing.Point(11, 253);
            this.lblCourse6.Name = "lblCourse6";
            this.lblCourse6.Size = new System.Drawing.Size(69, 20);
            this.lblCourse6.TabIndex = 8;
            this.lblCourse6.Text = "Course 6:";
            // 
            // lblCourse7
            // 
            this.lblCourse7.AutoSize = true;
            this.lblCourse7.Location = new System.Drawing.Point(11, 296);
            this.lblCourse7.Name = "lblCourse7";
            this.lblCourse7.Size = new System.Drawing.Size(69, 20);
            this.lblCourse7.TabIndex = 9;
            this.lblCourse7.Text = "Course 7:";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(11, 348);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(63, 20);
            this.lblFinal.TabIndex = 10;
            this.lblFinal.Text = "Overall :";
            // 
            // tbxGrade1
            // 
            this.tbxGrade1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxGrade1.Location = new System.Drawing.Point(87, 43);
            this.tbxGrade1.Name = "tbxGrade1";
            this.tbxGrade1.Size = new System.Drawing.Size(100, 27);
            this.tbxGrade1.TabIndex = 12;
            this.tbxGrade1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.tbxGrade1, "Please enter a grade for your 1st course");
            // 
            // tbxGrade2
            // 
            this.tbxGrade2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxGrade2.Location = new System.Drawing.Point(87, 85);
            this.tbxGrade2.Name = "tbxGrade2";
            this.tbxGrade2.Size = new System.Drawing.Size(100, 27);
            this.tbxGrade2.TabIndex = 13;
            this.tbxGrade2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.tbxGrade2, "Please enter a grade for your 2nd course");
            // 
            // tbxGrade3
            // 
            this.tbxGrade3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxGrade3.Location = new System.Drawing.Point(87, 127);
            this.tbxGrade3.Name = "tbxGrade3";
            this.tbxGrade3.Size = new System.Drawing.Size(100, 27);
            this.tbxGrade3.TabIndex = 14;
            this.tbxGrade3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.tbxGrade3, "Please enter a grade for your 3rd course");
            // 
            // tbxGrade4
            // 
            this.tbxGrade4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxGrade4.Location = new System.Drawing.Point(87, 168);
            this.tbxGrade4.Name = "tbxGrade4";
            this.tbxGrade4.Size = new System.Drawing.Size(100, 27);
            this.tbxGrade4.TabIndex = 15;
            this.tbxGrade4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.tbxGrade4, "Please enter a grade for your 4th course");
            // 
            // tbxGrade5
            // 
            this.tbxGrade5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxGrade5.Location = new System.Drawing.Point(87, 211);
            this.tbxGrade5.Name = "tbxGrade5";
            this.tbxGrade5.Size = new System.Drawing.Size(100, 27);
            this.tbxGrade5.TabIndex = 16;
            this.tbxGrade5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.tbxGrade5, "Please enter a grade for your 5th course");
            // 
            // tbxGrade6
            // 
            this.tbxGrade6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxGrade6.Location = new System.Drawing.Point(87, 253);
            this.tbxGrade6.Name = "tbxGrade6";
            this.tbxGrade6.Size = new System.Drawing.Size(100, 27);
            this.tbxGrade6.TabIndex = 17;
            this.tbxGrade6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.tbxGrade6, "Please enter a grade for your 6th course");
            // 
            // tbxGrade7
            // 
            this.tbxGrade7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxGrade7.Location = new System.Drawing.Point(87, 293);
            this.tbxGrade7.Name = "tbxGrade7";
            this.tbxGrade7.Size = new System.Drawing.Size(100, 27);
            this.tbxGrade7.TabIndex = 18;
            this.tbxGrade7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.tbxGrade7, "Please enter a grade for your 7th course");
            // 
            // lblCourseFinal
            // 
            this.lblCourseFinal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCourseFinal.Location = new System.Drawing.Point(87, 347);
            this.lblCourseFinal.Name = "lblCourseFinal";
            this.lblCourseFinal.Size = new System.Drawing.Size(101, 31);
            this.lblCourseFinal.TabIndex = 23;
            this.lblCourseFinal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLetter1
            // 
            this.lblLetter1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLetter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLetter1.Location = new System.Drawing.Point(205, 45);
            this.lblLetter1.Name = "lblLetter1";
            this.lblLetter1.Size = new System.Drawing.Size(101, 31);
            this.lblLetter1.TabIndex = 24;
            // 
            // lblLetter2
            // 
            this.lblLetter2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLetter2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLetter2.Location = new System.Drawing.Point(205, 88);
            this.lblLetter2.Name = "lblLetter2";
            this.lblLetter2.Size = new System.Drawing.Size(101, 31);
            this.lblLetter2.TabIndex = 25;
            // 
            // lblLetter3
            // 
            this.lblLetter3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLetter3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLetter3.Location = new System.Drawing.Point(205, 129);
            this.lblLetter3.Name = "lblLetter3";
            this.lblLetter3.Size = new System.Drawing.Size(101, 31);
            this.lblLetter3.TabIndex = 26;
            // 
            // lblLetter6
            // 
            this.lblLetter6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLetter6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLetter6.Location = new System.Drawing.Point(205, 255);
            this.lblLetter6.Name = "lblLetter6";
            this.lblLetter6.Size = new System.Drawing.Size(101, 31);
            this.lblLetter6.TabIndex = 29;
            // 
            // lblLetter5
            // 
            this.lblLetter5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLetter5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLetter5.Location = new System.Drawing.Point(205, 213);
            this.lblLetter5.Name = "lblLetter5";
            this.lblLetter5.Size = new System.Drawing.Size(101, 31);
            this.lblLetter5.TabIndex = 28;
            // 
            // lblLetter4
            // 
            this.lblLetter4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLetter4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLetter4.Location = new System.Drawing.Point(205, 171);
            this.lblLetter4.Name = "lblLetter4";
            this.lblLetter4.Size = new System.Drawing.Size(101, 31);
            this.lblLetter4.TabIndex = 27;
            // 
            // lblLetter7
            // 
            this.lblLetter7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLetter7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLetter7.Location = new System.Drawing.Point(205, 296);
            this.lblLetter7.Name = "lblLetter7";
            this.lblLetter7.Size = new System.Drawing.Size(101, 31);
            this.lblLetter7.TabIndex = 30;
            // 
            // lblLetterFinal
            // 
            this.lblLetterFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLetterFinal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLetterFinal.Location = new System.Drawing.Point(205, 347);
            this.lblLetterFinal.Name = "lblLetterFinal";
            this.lblLetterFinal.Size = new System.Drawing.Size(101, 31);
            this.lblLetterFinal.TabIndex = 31;
            // 
            // tbxOutput
            // 
            this.tbxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxOutput.Location = new System.Drawing.Point(14, 397);
            this.tbxOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxOutput.Multiline = true;
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.ReadOnly = true;
            this.tbxOutput.Size = new System.Drawing.Size(339, 122);
            this.tbxOutput.TabIndex = 32;
            // 
            // frmGPA
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(367, 571);
            this.Controls.Add(this.tbxOutput);
            this.Controls.Add(this.lblLetterFinal);
            this.Controls.Add(this.lblLetter7);
            this.Controls.Add(this.lblLetter6);
            this.Controls.Add(this.lblLetter5);
            this.Controls.Add(this.lblLetter4);
            this.Controls.Add(this.lblLetter3);
            this.Controls.Add(this.lblLetter2);
            this.Controls.Add(this.lblLetter1);
            this.Controls.Add(this.lblCourseFinal);
            this.Controls.Add(this.tbxGrade7);
            this.Controls.Add(this.tbxGrade6);
            this.Controls.Add(this.tbxGrade5);
            this.Controls.Add(this.tbxGrade4);
            this.Controls.Add(this.tbxGrade3);
            this.Controls.Add(this.tbxGrade2);
            this.Controls.Add(this.tbxGrade1);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblCourse7);
            this.Controls.Add(this.lblCourse6);
            this.Controls.Add(this.lblCourse5);
            this.Controls.Add(this.lblCourse4);
            this.Controls.Add(this.lblCourse3);
            this.Controls.Add(this.lblCourse2);
            this.Controls.Add(this.lblCourse1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGPA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sujeeve\'s Semester Grade Calculator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCourse1;
        private System.Windows.Forms.Label lblCourse2;
        private System.Windows.Forms.Label lblCourse3;
        private System.Windows.Forms.Label lblCourse4;
        private System.Windows.Forms.Label lblCourse5;
        private System.Windows.Forms.Label lblCourse6;
        private System.Windows.Forms.Label lblCourse7;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.TextBox tbxGrade1;
        private System.Windows.Forms.TextBox tbxGrade2;
        private System.Windows.Forms.TextBox tbxGrade3;
        private System.Windows.Forms.TextBox tbxGrade4;
        private System.Windows.Forms.TextBox tbxGrade5;
        private System.Windows.Forms.TextBox tbxGrade6;
        private System.Windows.Forms.TextBox tbxGrade7;
        private System.Windows.Forms.Label lblCourseFinal;
        private System.Windows.Forms.Label lblLetter1;
        private System.Windows.Forms.Label lblLetter2;
        private System.Windows.Forms.Label lblLetter3;
        private System.Windows.Forms.Label lblLetter6;
        private System.Windows.Forms.Label lblLetter5;
        private System.Windows.Forms.Label lblLetter4;
        private System.Windows.Forms.Label lblLetter7;
        private System.Windows.Forms.Label lblLetterFinal;
        private System.Windows.Forms.TextBox tbxOutput;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

