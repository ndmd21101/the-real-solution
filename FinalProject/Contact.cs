#region Comment Header
/*
 * Author : Sujeeve Sureshkumar
 * Date: March 25th, 2022
 * GitHub URL: https://github.com/SujeeveSuresh/NETD
 * GitHub Website: Testing in the website editor
 * ID: 100790769
 * Title: NETD2202 - Lab 04
 * Description: this is my class where i set my properties for my form with constructors.
 */
#endregion
#region USING
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace FinalProject
{
    class Contact
    {
        /// <summary>
        /// where I declare my properties for my gets and sets
        /// </summary>
        #region PROPERTIES

        //get and sets for first name
        public String FirstName { get; set; }
        //get and sets for last name
        public String LastName { get; set; }
        //get and sets for Date
        public DateTime Date { get; set; } = DateTime.Now;
        //get and sets for email address
        public String EmailAddress { get; set; }
        //get and sets for phone number
        public String PhoneNumber { get; set; }
        //get and sets for contacted 
        public Boolean ContactStatus { get; set; }

        #endregion

        #region CONSTRUCTORS
        //public Contact
        public Contact() { }

      
        public Contact(String firstName, String lastName, String emailAddress, 
                                    String phoneNumber, Boolean contactStatus)
        {

            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
            ContactStatus = contactStatus;
        }

        #endregion

        #region METHODS

        #region CUSTOM METHODS
        #endregion

        #region STATIC

       
 


        #endregion

        #endregion

   

    }
}
