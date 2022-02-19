using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 Name: Nguyen Duc
Date: 13th Feb, 2022
File name: Grades Calculator

 */


namespace LAB_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



        }
        #region ArraysDeclaration
        TextBox[] grades;
        Label[] gradesLet;




        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            grades = new TextBox[] { txtCourse1, txtCourse2, txtCourse3, txtCourse4, txtCourse5, txtCourse6, txtCourse7 };
            gradesLet = new Label[] { lblCourse1, lblCourse2, lblCourse3, lblCourse4,lblCourse5,lblCourse6,lblCourse7 };



        }
        #region Input
        private void txtCourse1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCourse2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCourse3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCourse4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCourse5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCourse6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCourse7_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
        #region Results
        private void txtSemNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLet1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLet2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLet3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLet4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLet5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLet6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLet7_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLetSem_TextChanged(object sender, EventArgs e)
        {

        }


        #endregion
        #region Functions
        public void InputValidation()
        {

            bool retVal = true;
            for (int i =0; i<7; i++)
            {

                retVal = double.TryParse(grades[i].Text, out double gradesNum);
                if (grades[i].TextLength == 0)
                {
                    continue;
                }
                if (retVal != true)
                {
                    txtError.Text = "Grades must be numbers between 0-100. Please check and try again.";
                }
                if (gradesNum < 0 && gradesNum > 100)
                {
                    txtError.Text = "Grades must be numbers between 0-100. Please check and try again.";
                }
               
            }
        }


        /*This function is to calculate grades and validate all inputs*/
        private void NumToLetGrade()
        {
            int x = 0;
            int totalGrades = 0;
            int coursesCount = 0;
            bool retVal = true;
            #region CourseGradeToLet
            while (x < 7)
            {
                for (int i = 0; i < grades.Length; i++)
                {

                    #region comment
                    /*
                    bool retVal = true;
                    retVal = double.TryParse(grades[i].Text, out double gradesNum);
                    if (retVal != true)
                    {
                        txtError.Text = "Grades must be numbers between 0-100. Please check and try again.";
                    }
                    if (Convert.ToDouble(grades[i].Text) < 0 && Convert.ToDouble(grades[i].Text) > 100)
                    {
                        txtError.Text = "Grades must be numbers between 0-100. Please check and try again.";
                    }
                    if (grades[i].TextLength == 0)
                    {
                        continue;
                    }
                    if (Convert.ToDouble(grades[i].Text) < 50)
                    {
                        gradesLet[i].Text = "F";
                        coursesCount++;
                        totalGrades += Convert.ToInt32(grades[i].Text);
                    }
                    if (Convert.ToDouble(grades[i].Text) >= 50 && Convert.ToDouble(grades[i].Text) <= 51)
                    {
                        gradesLet[i].Text = "D-";
                        coursesCount++;
                        totalGrades += Convert.ToInt32(grades[i].Text);
                    }
                    if (Convert.ToDouble(grades[i].Text) >= 52 && Convert.ToDouble(grades[i].Text) <= 57)
                    {
                        gradesLet[i].Text = "D";
                        coursesCount++;
                        totalGrades += Convert.ToInt32(grades[i].Text);
                    }
                    if (Convert.ToDouble(grades[i].Text) >= 58 && Convert.ToDouble(grades[i].Text) <= 59)
                    {
                        gradesLet[i].Text = "D+";
                        coursesCount++;
                        totalGrades += Convert.ToInt32(grades[i].Text);
                    }
                    if (Convert.ToDouble(grades[i].Text) >= 60 && Convert.ToDouble(grades[i].Text) <= 61)
                    {
                        gradesLet[i].Text = "C-";
                        coursesCount++;
                        totalGrades += Convert.ToInt32(grades[i].Text);
                    }
                    if (Convert.ToDouble(grades[i].Text) >= 62 && Convert.ToDouble(grades[i].Text) <= 67)
                    {
                        gradesLet[i].Text = "C";
                        coursesCount++;
                        totalGrades += Convert.ToInt32(grades[i].Text);
                    }
                    if (Convert.ToDouble(grades[i].Text) >= 68 && Convert.ToDouble(grades[i].Text) <= 69)
                    {
                        gradesLet[i].Text = "C+";
                        coursesCount++;
                        totalGrades += Convert.ToInt32(grades[i].Text);
                    }
                    if (Convert.ToDouble(grades[i].Text) >= 70 && Convert.ToDouble(grades[i].Text) <= 71)
                    {
                        gradesLet[i].Text = "B-";
                        coursesCount++;
                        totalGrades += Convert.ToInt32(grades[i].Text);
                    }
                    if (Convert.ToDouble(grades[i].Text) >= 72 && Convert.ToDouble(grades[i].Text) <= 77)
                    {
                        gradesLet[i].Text = "B";
                        coursesCount++;
                        totalGrades += Convert.ToInt32(grades[i].Text);
                    }
                    if (Convert.ToDouble(grades[i].Text) >= 78 && Convert.ToDouble(grades[i].Text) <= 79)
                    {
                        gradesLet[i].Text = "B+";
                        coursesCount++;
                        totalGrades += Convert.ToInt32(grades[i].Text);
                    }
                    if (Convert.ToDouble(grades[i].Text) >= 80 && Convert.ToDouble(grades[i].Text) <= 81)
                    {
                        gradesLet[i].Text = "A-";
                        coursesCount++;
                        totalGrades += Convert.ToInt32(grades[i].Text);
                    }
                    if (Convert.ToDouble(grades[i].Text) >= 82 && Convert.ToDouble(grades[i].Text) <= 89)
                    {
                        gradesLet[i].Text = "A";
                        coursesCount++;
                        totalGrades += Convert.ToInt32(grades[i].Text);
                    }
                    if (Convert.ToDouble(grades[i].Text) >= 90 && Convert.ToDouble(grades[i].Text) <= 100)
                    {
                        gradesLet[i].Text = "A+";
                        coursesCount++;
                        totalGrades += Convert.ToInt32(grades[i].Text);
                    }
                    */
                    #endregion

                    if (grades[i].TextLength == 0)
                    {
                        continue;
                    }
                    retVal = double.TryParse(grades[i].Text, out double gradesNum);
                    if (retVal == false || (Convert.ToDouble(grades[i].Text) < 0 && Convert.ToDouble(grades[i].Text) > 100))
                    {
                        txtError.Text = "Grades can only be numbers from 0-100. Please check and try again.";
                        return;
                    }
                    if (retVal == true && Convert.ToDouble(grades[i].Text) > 0 && Convert.ToDouble(grades[i].Text) < 100)
                    {
                        if (Convert.ToDouble(grades[i].Text) < 50)
                        {
                            gradesLet[i].Text = "F";
                            coursesCount++;
                            totalGrades += Convert.ToInt32(grades[i].Text);
                            x++;

                        }
                        if (Convert.ToDouble(grades[i].Text) >= 50 && Convert.ToDouble(grades[i].Text) <= 51)
                        {
                            gradesLet[i].Text = "D-";
                            coursesCount++;
                            totalGrades += Convert.ToInt32(grades[i].Text);
                            x++;

                        }
                        if (Convert.ToDouble(grades[i].Text) >= 52 && Convert.ToDouble(grades[i].Text) <= 57)
                        {
                            gradesLet[i].Text = "D";
                            coursesCount++;
                            totalGrades += Convert.ToInt32(grades[i].Text);
                            x++;

                        }
                        if (Convert.ToDouble(grades[i].Text) >= 58 && Convert.ToDouble(grades[i].Text) <= 59)
                        {
                            gradesLet[i].Text = "D+";
                            coursesCount++;
                            totalGrades += Convert.ToInt32(grades[i].Text);
                            x++;

                        }
                        if (Convert.ToDouble(grades[i].Text) >= 60 && Convert.ToDouble(grades[i].Text) <= 61)
                        {
                            gradesLet[i].Text = "C-";
                            coursesCount++;
                            totalGrades += Convert.ToInt32(grades[i].Text);
                            x++;
                        }
                        if (Convert.ToDouble(grades[i].Text) >= 62 && Convert.ToDouble(grades[i].Text) <= 67)
                        {
                            gradesLet[i].Text = "C";
                            coursesCount++;
                            totalGrades += Convert.ToInt32(grades[i].Text);
                            x++;
                        }
                        if (Convert.ToDouble(grades[i].Text) >= 68 && Convert.ToDouble(grades[i].Text) <= 69)
                        {
                            gradesLet[i].Text = "C+";
                            coursesCount++;
                            totalGrades += Convert.ToInt32(grades[i].Text);
                            x++;
                        }
                        if (Convert.ToDouble(grades[i].Text) >= 70 && Convert.ToDouble(grades[i].Text) <= 71)
                        {
                            gradesLet[i].Text = "B-";
                            coursesCount++;
                            totalGrades += Convert.ToInt32(grades[i].Text);
                            x++;
                        }
                        if (Convert.ToDouble(grades[i].Text) >= 72 && Convert.ToDouble(grades[i].Text) <= 77)
                        {
                            gradesLet[i].Text = "B";
                            coursesCount++;
                            totalGrades += Convert.ToInt32(grades[i].Text);
                            x++;
                        }
                        if (Convert.ToDouble(grades[i].Text) >= 78 && Convert.ToDouble(grades[i].Text) <= 79)
                        {
                            gradesLet[i].Text = "B+";
                            coursesCount++;
                            totalGrades += Convert.ToInt32(grades[i].Text);
                            x++;
                        }
                        if (Convert.ToDouble(grades[i].Text) >= 80 && Convert.ToDouble(grades[i].Text) <= 81)
                        {
                            gradesLet[i].Text = "A-";
                            coursesCount++;
                            totalGrades += Convert.ToInt32(grades[i].Text);
                            x++;
                        }
                        if (Convert.ToDouble(grades[i].Text) >= 82 && Convert.ToDouble(grades[i].Text) <= 89)
                        {
                            gradesLet[i].Text = "A";
                            coursesCount++;
                            totalGrades += Convert.ToInt32(grades[i].Text);
                            x++;
                        }
                        if (Convert.ToDouble(grades[i].Text) >= 90 && Convert.ToDouble(grades[i].Text) <= 100)
                        {
                            gradesLet[i].Text = "A+";
                            coursesCount++;
                            totalGrades += Convert.ToInt32(grades[i].Text);
                            x++;
                        }
                    }
                }
                double avgGrades = totalGrades / coursesCount;
                txtSemNum.Text = Convert.ToString(avgGrades);
                txtCourse1.ReadOnly = true;
                txtCourse2.ReadOnly = true;
                txtCourse3.ReadOnly = true;
                txtCourse4.ReadOnly = true;
                txtCourse5.ReadOnly = true;
                txtCourse6.ReadOnly = true;
                txtCourse7.ReadOnly = true;
                if (avgGrades < 50)
                {
                    lblSem.Text = "F";

                }
                if (avgGrades >= 50 && avgGrades <= 51)
                {
                    lblSem.Text = "D-";

                }
                if (avgGrades >= 52 && avgGrades <= 57)
                {
                    lblSem.Text = "D";

                }
                if (avgGrades >= 58 && avgGrades <= 59)
                {
                    lblSem.Text = "D+";

                }
                if (avgGrades >= 60 && avgGrades <= 61)
                {
                    lblSem.Text = "C-";
                }
                if (avgGrades >= 62 && avgGrades <= 67)
                {
                    lblSem.Text = "C";

                }
                if (avgGrades >= 68 && avgGrades <= 69)
                {
                    lblSem.Text = "C+";

                }
                if (avgGrades >= 70 && avgGrades <= 71)
                {
                    lblSem.Text = "B-";

                }
                if (avgGrades >= 72 && avgGrades <= 77)
                {
                    lblSem.Text = "B";

                }
                if (avgGrades >= 78 && avgGrades <= 79)
                {
                    lblSem.Text = "B+";

                }
                if (avgGrades >= 80 && avgGrades <= 81)
                {
                    lblSem.Text = "A-";

                }
                if (avgGrades >= 82 && avgGrades <= 89)
                {
                    lblSem.Text = "A";

                }
                if (avgGrades >= 90 && avgGrades <= 100)
                {
                    lblSem.Text = "A+";

                }

                #endregion
            }
            #region Semester Grade Conversion
            /*
            if (avgGrades < 50)
            {
                lblSem.Text = "F";

            }
            if (avgGrades >= 50 && avgGrades <= 51)
            {
                lblSem.Text = "D-";

            }
            if (avgGrades >= 52 && avgGrades <= 57)
            {
                lblSem.Text = "D";

            }
            if (avgGrades >= 58 && avgGrades <= 59)
            {
                lblSem.Text = "D+";

            }
            if (avgGrades >= 60 && avgGrades <= 61)
            {
                lblSem.Text = "C-";
            }
            if (avgGrades >= 62 && avgGrades <= 67)
            {
                lblSem.Text = "C";

            }
            if (avgGrades >= 68 && avgGrades <= 69)
            {
                lblSem.Text = "C+";

            }
            if (avgGrades >= 70 && avgGrades <= 71)
            {
                lblSem.Text = "B-";

            }
            if (avgGrades >= 72 && avgGrades <= 77)
            {
                lblSem.Text = "B";

            }
            if (avgGrades >= 78 && avgGrades <= 79)
            {
                lblSem.Text = "B+";

            }
            if (avgGrades >= 80 && avgGrades <= 81)
            {
                lblSem.Text = "A-";

            }
            if (avgGrades >= 82 && avgGrades <= 89)
            {
                lblSem.Text = "A";

            }
            if (avgGrades >= 90 && avgGrades <= 100)
            {
                lblSem.Text = "A+";

            }
            */
            #endregion
           
        }
        /*This function is to reset the program*/
        private void SetDefault()
        {
            txtCourse1.ReadOnly = false;
            txtCourse2.ReadOnly = false;
            txtCourse3.ReadOnly = false;
            txtCourse4.ReadOnly = false;
            txtCourse5.ReadOnly = false;
            txtCourse6.ReadOnly = false;
            txtCourse7.ReadOnly = false;
            txtCourse1.Text = "";
            txtCourse2.Text = "";
            txtCourse3.Text = "";
            txtCourse4.Text = "";
            txtCourse5.Text = "";
            txtCourse6.Text = "";
            txtCourse7.Text = "";
            txtError.Text = "";
            lblCourse1.Text = "";
            lblCourse2.Text = "";
            lblCourse3.Text = "";
            lblCourse4.Text = "";
            lblCourse5.Text = "";
            lblCourse6.Text = "";
            lblCourse7.Text = "";
            lblSem.Text = "";
            txtSemNum.Text = "";
        }
        #endregion
        #region Buttons
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            NumToLetGrade();
            

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefault();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion


        #region Error Text Box
        private void txtError_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtCourse1_Leave(object sender, EventArgs e)
        {

        }






    }
}
#endregion
