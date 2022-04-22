//Comment header
#region header
/* ----------------------------------
 * Author: Sujeeve Sureshkumar
 * Date: Feb 10th 2022
 * Title: Week 5 - Lab02 
 * Description:
 *      This program finds the users final semester average for 7 courses and displays the grade letter with it.
 */
#endregion

//Tells user what using systems we are using
#region Using
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace FinalProject
{
    public partial class frmGPA : Form
    {
        public frmGPA()
        {
            InitializeComponent();
        }

        #region Variables
        // Global Variables
        Label[] courseLetter;
        TextBox[] courseGrade;

        const int LowestGrade = 0;
        const int HighestGrade = 0;

        #endregion


        #region MainFrame
        /// <summary>
        /// This is the main frame where I set my arrays.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            // Initialize the courseNum label array so it populates the tables in an array
            courseLetter = new Label[] {lblLetter1, lblLetter2, lblLetter3, lblLetter4, lblLetter5, lblLetter6, lblLetter7};

            // initialize the courseGrade text box array and it populates the appropriate text boxes
            courseGrade = new TextBox[] {tbxGrade1, tbxGrade2, tbxGrade3, tbxGrade4, tbxGrade5, tbxGrade6, tbxGrade7};

            //Load program with default properties
            SetDefaults();
        }
        #endregion
        

        #region Click Events

        /// <summary>
        /// This is my calculate button, it is used to calculate the average of my grades.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ValidateGrades();
            NumericGrades();
           
        }

        /// <summary>
        /// This button is used for my reset button, this sets all my functions to its default values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            //goes to a custom method called SetDefaults.
            SetDefaults();
        }

        /// <summary>
        /// This button is used to exit my program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the application
            this.Close();
        }

        #endregion


        #region Custom methods

        private void SetDefaults()
        {
            //Sets the focus to the textbox 1 for course one.
            tbxGrade1.Focus();
         

            //resets the numbers entered in the text boxes
            foreach (TextBox tBox in courseGrade) { tBox.Clear(); }
            
            //resets the numbers entered in the labels
            foreach (Label lbl in courseLetter) {lbl.ResetText(); }

            //resets the error box.
            tbxOutput.Text = string.Empty;

            //resets final grade box
            lblCourseFinal.Text = string.Empty;

            //reseting the text box so inputs can be entered again
            tbxGrade1.Enabled = true;
            tbxGrade2.Enabled = true;
            tbxGrade3.Enabled = true;
            tbxGrade4.Enabled = true;
            tbxGrade5.Enabled = true;
            tbxGrade6.Enabled = true;
            tbxGrade7.Enabled = true;

            //reenabling calculate button
            btnCalculate.Enabled = true;

        }

        private bool ValidateGrades()
        {
            //Sets the returnValue to true
            bool returnValue = true;

            //Temporary value
            double temp;

            //This foreach statement takes all the information we entered in the grades textboxes 
            foreach (TextBox tbox in courseGrade)
            {
                if (double.TryParse(tbox.Text, out temp))
                {
                    if (temp >= LowestGrade  && temp <= HighestGrade)
                    {
                        return returnValue;
                    }

                    else
                    {
                      
                        tbxOutput.Text = "The values you entered is not in range, Try again";
                    }

                }
                else
                {
                    returnValue = false;
                    tbxOutput.Text = "The values you entered is not numeric, Try again the grade should be in the range of 0 to 100.";
                    

                }
                
            }
            return returnValue;
        }

        private void NumericGrades()
        {

            bool returnValue = true;

            //this counts the grades
            double count = 0;

            //this gets a hold of the numbers of the grade
            double gradeSum = 0;

            for (int i = 0; i < courseGrade.Length; i++)
            {
              
                //This statement takes all the information we entered in the grades textboxes 
                returnValue = double.TryParse(courseGrade[i].Text, out double temp);
                   
                //this happens if the return value is true
                    if (returnValue == true)
                    {

                        //this if statement means if the grade entered is less than 50 its a F
                        if (Convert.ToDouble(courseGrade[i].Text) < 50)
                        {
                            courseLetter[i].Text = "F";
                            gradeSum += Convert.ToInt32(courseGrade[i].Text);
                        count++; 
                        }
                        //this if statement means if the grade entered between 50 to 51 its a D-  
                        if (Convert.ToDouble(courseGrade[i].Text) >= 50 && Convert.ToDouble(courseGrade[i].Text) <= 51)
                        {
                            courseLetter[i].Text = "D-";
                            gradeSum += Convert.ToInt32(courseGrade[i].Text);
                            count++;    
                        }

                        //this if statement means if the grade entered between 52 to 57 its a D
                        if (Convert.ToDouble(courseGrade[i].Text) >= 52 && Convert.ToDouble(courseGrade[i].Text) <= 57)
                        {
                            courseLetter[i].Text = "D";
                            gradeSum += Convert.ToInt32(courseGrade[i].Text);
                            count++;
                        }

                        //this if statement means if the grade entered between 58 to 59 its a D+
                        if (Convert.ToDouble(courseGrade[i].Text) >= 58 && Convert.ToDouble(courseGrade[i].Text) <= 59)
                        {
                            courseLetter[i].Text = "D+";
                            gradeSum += Convert.ToInt32(courseGrade[i].Text);
                            count++;
                        }

                        //this if statement means if the grade entered between 60 to 61 its a C-
                        if (Convert.ToDouble(courseGrade[i].Text) >= 60 && Convert.ToDouble(courseGrade[i].Text) <= 61)
                        {
                            courseLetter[i].Text = "C-";
                            gradeSum += Convert.ToInt32(courseGrade[i].Text);
                            count++;
                        }

                        //this if statement means if the grade entered between 62 to 67 its a C
                        if (Convert.ToDouble(courseGrade[i].Text) >= 62 && Convert.ToDouble(courseGrade[i].Text) <= 67)
                        {
                            courseLetter[i].Text = "C";
                            gradeSum += Convert.ToInt32(courseGrade[i].Text);
                            count++;
                        }

                        //this if statement means if the grade entered between 68 to 69 its a C+
                        if (Convert.ToDouble(courseGrade[i].Text) >= 68 && Convert.ToDouble(courseGrade[i].Text) <= 69)
                        {
                            courseLetter[i].Text = "C+";
                            gradeSum += Convert.ToInt32(courseGrade[i].Text);
                            count++;
                        }

                        //this if statement means if the grade entered between 70 to 71 its a B-
                        if (Convert.ToDouble(courseGrade[i].Text) >= 70 && Convert.ToDouble(courseGrade[i].Text) <= 71)
                        {
                            courseLetter[i].Text = "B-";
                            gradeSum += Convert.ToInt32(courseGrade[i].Text);
                            count++;
                        }

                        //this if statement means if the grade entered between 72 to 77 its a B
                        if (Convert.ToDouble(courseGrade[i].Text) >= 72 && Convert.ToDouble(courseGrade[i].Text) <= 77)
                        {
                            courseLetter[i].Text = "B";
                            gradeSum += Convert.ToInt32(courseGrade[i].Text);
                            count++;
                        }

                        //this if statement means if the grade entered between 78 to 79 its a B+
                        if (Convert.ToDouble(courseGrade[i].Text) >= 78 && Convert.ToDouble(courseGrade[i].Text) <= 79)
                        {
                            courseLetter[i].Text = "B+";
                            gradeSum += Convert.ToInt32(courseGrade[i].Text);
                            count++;
                        }

                        //this if statement means if the grade entered between 80 to 81 its a A-
                        if (Convert.ToDouble(courseGrade[i].Text) >= 80 && Convert.ToDouble(courseGrade[i].Text) <= 81)
                        {
                            courseLetter[i].Text = "A-";
                            count++;
                            gradeSum += Convert.ToInt32(courseGrade[i].Text);
                        }

                        //this if statement means if the grade entered between 82 to 89 its a A
                        if (Convert.ToDouble(courseGrade[i].Text) >= 82 && Convert.ToDouble(courseGrade[i].Text) <= 89)
                        {
                            courseLetter[i].Text = "A";
                            gradeSum += Convert.ToInt32(courseGrade[i].Text);
                            count++;
                            
                        }

                        //this if statement means if the grade entered between 90 to 100 its a B- A+
                        if (Convert.ToDouble(courseGrade[i].Text) >= 90 && Convert.ToDouble(courseGrade[i].Text) <= 100)
                        {
                            courseLetter[i].Text = "A+";
                            gradeSum += Convert.ToInt32(courseGrade[i].Text);
                            count++;                   
                    }
                        }
              
                
            }

            //final grade calculation 
            double avgFinal = gradeSum / count;


            //final grade display 
            lblCourseFinal.Text = avgFinal.ToString();

            //disable the texbox
            tbxGrade1.Enabled = false;
            tbxGrade2.Enabled = false;
            tbxGrade3.Enabled = false;
            tbxGrade4.Enabled = false;
            tbxGrade5.Enabled = false;
            tbxGrade6.Enabled = false;
            tbxGrade7.Enabled = false;

            //disable calculate button
            btnCalculate.Enabled = false;

            //makes the focus set to the reset button
            btnReset.Focus();        

        }
        #endregion


    }
}
