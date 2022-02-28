/*
Droid Class Definition
NETD2202 WEEK 7 - Droid Factory Demo
Feb 22nd,2022
Duc Nguyen
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace W7_Demo_Classes1
{
    #region Main Droid Class
    class Droid
    {

        public const int MinDesignationLength = 3;
        public const int MaxDesignationLength = 8;
        public const int MinOwnerLength = 5;
        public static List<Droid> Droids = new List<Droid>();
        #region Properties

        public string Designation { get; set; }
        public bool IsInService { get; set; }
        public string Owner { get; set; }
        public Color PrimaryColor { get; set; }
        public Color SecondaryColor { get; set; }



        #endregion
        #region Constructors
        /// <summary>
        /// Default Droid Constructor
        /// </summary>
        public Droid()
        {
            Designation = String.Empty;
            Owner = string.Empty;
            PrimaryColor = Color.Gray;
            SecondaryColor = Color.Gray;
            IsInService = false;
        }
        /// <summary>
        /// Input Value Constructor
        /// </summary>
        /// <param name="designation">The name of the droid</param>
        /// <param name="owner">Is the droid being used</param>
        /// <param name="isInService">The name of the current owner</param>
        /// <param name="primaryColor">The main color recognizing the droid</param>
        /// <param name="secondaryColor">Any secondary color to recognize the droid</param>
        public Droid(string designation, string owner, bool isInService, Color primaryColor, Color secondaryColor)
        {
            Designation = designation;
            IsInService = isInService;
            Owner = owner;
            PrimaryColor = primaryColor;
            SecondaryColor = secondaryColor;
        }
        #endregion
        #region Custom Methods
        public static Droid FindDroid(string designation)
        {
            // look through the list until we find the droid we are looking for
            Droid returnDroid = new Droid();

            foreach (Droid d in Droids)
            {
                if (d.Designation == designation)
                {
                    return d;
                }
            }

            return returnDroid;
        }
        public void SellDroid(string owner, bool isInService)
        {
            Owner = owner;
            IsInService = isInService;
        }
        #endregion
    }
    #endregion
}
