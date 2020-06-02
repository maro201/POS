using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Adress
    {
        /*
         * street line 1
         * street line 2
         * city
         * state/province
         * postal code
         * country
         * adress type
         * validate()
         * 
         */

        public Adress()
        {

        }

        public Adress(int adressId)
        {
            AddressId = adressId;
        }

        public int AddressId { get; private set; }
        public int AdressType { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }

        /// <summary>
        /// Validates the address data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (PostalCode == null) isValid = false;

            ///if (City == null) isValid = false;
            ///if (Country == null) isValid = false;
            ///if (State == null) isValid = false;


        




            return isValid;
        }


    }
}
