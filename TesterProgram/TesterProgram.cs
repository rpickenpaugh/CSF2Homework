using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;

namespace TesterProgram
{
    class TesterProgram
    {
        static void Main(string[] args)
        {
            Console.Title = "-= Tester Program -=";
            Console.WriteLine("Tester Program");
            #region Student

            Console.WriteLine("-----Student-----");

            Student s1 = new Student
            {
                FirstName = "Robert",
                LastName = "Pickenpaugh",
                ID = "Student",
                GPA = 1.2f
            };

            Student s2 = new Student("Robert", "Pickenpaugh", "Student", 1.2f);

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            #endregion
            Console.WriteLine("-----Vehicle-----");
            #region Vehicle

            Vehicle v1 = new Vehicle
            {
                Make = "Mazda",
                Model = "Mazda 3",
                Year = 2015,
                Weight = 2000f
            };

            Vehicle v2 = new Vehicle("Mazda", "Mazda 3", 2015, 2000f);

            Console.WriteLine(v1);
            Console.WriteLine(v2);

            #endregion
            Console.WriteLine("-----Login-----");
            #region Login

            Login l1 = new Login
            {
                Username = "RobertP",
                Password = "secret"
            };

            Login l2 = new Login("RobertP", "secret");

            Console.WriteLine(l1);
            Console.WriteLine(l2);
            #endregion
            Console.WriteLine("-----ContactInfo-----");
            #region ContactInfo

            ContactInfo ci1 = new ContactInfo
            {
                StreetAddress = "1212 House Road",
                City = "Kansas City",
                State = "MO",
                Zip = "64030",
                Phone = "123-345-6789",
                Email = "professionalemail@yahoo.com",
            };
            ContactInfo ci2 = new ContactInfo("1212 House Road", "Kansas City", "MO", "64030", "123-345-6789", "professionalemail@yahoo.com");

            Console.WriteLine(ci1);
            Console.WriteLine(ci2);
            #endregion

            Console.WriteLine("-----Customer-----");

            #region Customer

            Customer c1 = new Customer
            {
                CustomerID = "123",
                FirstName = "Robbie",
                LastName = "Owen",
                ContactInformation = ci1
            };
            Customer c2 = new Customer("123", "Robbie", "Owen", ci1);
            Console.WriteLine(c1);
            Console.WriteLine(c2);

            #endregion

            Console.WriteLine("-----CreditCardAccount");

            #region CreditCardAccount

            CreditCardAccount cca1 = new CreditCardAccount
            {
                AccountNumber = 1299565,
                CustomerInfo = c1,
                Balance = 500.12m,
                IsPastDue = true,
                AnnualInterestRate = 5m
            };
            CreditCardAccount cca2 = new CreditCardAccount(1299565, c1, 500.12m, true, 5m);
            Console.WriteLine(cca1);
            Console.WriteLine(cca2);
            #endregion

            Console.WriteLine("-----Book-----");

            #region Book

            Book b1 = new Book
            {
                Title = "The Way of Kings",
                Author = "Brandon Sanderson",
                NumberOfPages = 1007
            };

            Book b2 = new Book("The Way of Kings", "Brandon Sanderson", 1007);

            Console.WriteLine(b1);
            Console.WriteLine(b2);

            #endregion
            //Library
            //TODO

            //Song
            //TODO

            //Artist
            //TODO

            Console.WriteLine("-----MotorHome-----");

            #region MotorHome

            MotorHome mh1 = new MotorHome("Mazda", "Mazda 3-bed", 2017, 2000f, 3);
           
            MotorHome mh2 = new MotorHome
            {
                Make = "Mazda",
                Model = "Mazda 3-bed",
                Year = 2017,
                Weight = 2000f,
                NumberOfBeds = 3
            };

            Console.WriteLine(mh1);
            Console.WriteLine(mh2);
            #endregion

            Console.WriteLine("-----Truck-----");

            #region Truck

            Truck tr1 = new Truck("Mazda", "Mazda 3 - Truck", 2018, 3000f, 10000f);
            Truck tr2 = new Truck
            {
                Make = "Mazda",
                Model = "Mazda 3 - Truck",
                Year = 2018,
                Weight= 3000f,
                LoadCapacityLbs = 10000f
            };
            Console.WriteLine(tr1);
            Console.WriteLine(tr2);
            #endregion
        }//end Main()
    }
}
