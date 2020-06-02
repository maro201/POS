using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        ///<summary
        ///Retreive one customer.
        ///</summary>
        ///

        public Customer Retreive(int customerid)
        {
            //Create the instance of the Customer class
            //Pass in the requested id
            Customer customer = new Customer(customerid);

            //Code that retrevies the defined customer

            //Temporary hard-coded values to return
            //a populated customer
            if (customerid == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }
            return customer;

         


        }

        ///<summary>
        ///Saves the current customer
        /// </summary>
        ///<returns></returns>
        public bool Save(Customer customer)
        {
            //Code that saves the passed customer

            return true;
        }


    }
}
