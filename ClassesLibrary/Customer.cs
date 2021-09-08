using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Customer
    {
        //fields

        //properties

        public string CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactInfo ContactInformation { get; set; }

        //constructors

        public Customer(string customerId, string firstName, string lastName, ContactInfo contactInformation)
        {
            CustomerID = customerId;
            FirstName = firstName;
            LastName = lastName;
            ContactInformation = contactInformation;
        }
        public Customer()
        {

        }

        //methods

        public override string ToString()
        {
            return string.Format("" +
                "Customer: {0}\n" +
                "Name: {1} {2}\n" +
                "ContactInfo:\n{3}",
                CustomerID, FirstName, LastName, ContactInformation);
        }

    }//end class
}
