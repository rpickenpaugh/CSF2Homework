using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class CreditCardAccount
    {
        //fields

        //properties
        public int AccountNumber { get; set; }
        public Customer CustomerInfo { get; set; }
        public decimal Balance { get; set; }
        public bool IsPastDue { get; set; }
        public decimal AnnualInterestRate { get; set; }

        //constructors

        public CreditCardAccount(int accountNumber, Customer customerInfo, decimal balance, bool isPastDue, decimal annualInterestRate)
        {
            AccountNumber = accountNumber;
            CustomerInfo = customerInfo;
            Balance = balance;
            IsPastDue = isPastDue;
            AnnualInterestRate = annualInterestRate;
        }
        public CreditCardAccount()
        {

        }

        //methods

        public override string ToString()
        {
            string pastDue = "";
            if (IsPastDue)
            {
                //Console.ForegroundColor = ConsoleColor.Red;
                pastDue = "Late";
                //Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                pastDue = "On Time!";
            }

            return string.Format("" +
                "Account Number: {0}\n" +
                "Customer Info: {1}\n" +
                "Balance: {2:c}\n" +
                "Status Of Account: " + pastDue + "\n" +
                "Annual Interest Rate: {4}%\n",
                AccountNumber, CustomerInfo, Balance, pastDue, AnnualInterestRate);
        }

    }//end class
}
