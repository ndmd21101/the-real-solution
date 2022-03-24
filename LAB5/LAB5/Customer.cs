using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;

namespace LAB5
{
    public class Customer
    {
        #region Properties
        public static readonly int Count = 0;
        public readonly int Id = 0;
        public Boolean Contacted { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
       
        public DateTime Date { get; set; } = DateTime.Now;

        #endregion

        public Customer()
        {
          
        }
        /// <param name="id"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="emailAddress"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="contacted"></param>
        /// <param name="date"></param>
        public Customer (string firstName, string lastName, string emailAddress, string phoneNumber, Boolean contacted, DateTime date, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
            Contacted = contacted;
            Date = date;
            Id = id;
        }
        public static string GetStatus(Customer c)
        {
            string status = c.FirstName + " " + c.LastName + "("+c.EmailAddress + " / " + c.PhoneNumber+")"+" from TIMES has not been contacted";
            return status;
        }
        
        public static Customer FindCustomer(List<Customer> inputCustomer, int id)
        {
            return inputCustomer.Find(c => c.Id == id);
        }
        public static Boolean CustomerExists(List<Customer> inputCustomers, int id)
        {
            return inputCustomers.FindAll(c => c.Id == id).Count > 0;
        }
        private void ValidateEmail()
        {
            string email_output;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(EmailAddress);
            if (match.Success)
               email_output  = "";
            else
                email_output = EmailAddress+" is Invalid Email Address";
        }


    }
}
