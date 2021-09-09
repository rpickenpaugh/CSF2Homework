using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Library
    {
        //fields

        //properties
        public string LibraryName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public List<Book> Books { get; set; }

        //constructors

        public Library(string libraryName, string streetAddress, string city, string state, string zip, List<Book> books)
        {
            LibraryName = libraryName;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
            Books = books;
        }

        public Library()
        {

        }

        //methods

        public override string ToString()
        {
            string bookCount = "";
            foreach (Book bookC in Books)
            {
                bookCount += bookC + "\n";
            }

            return string.Format("" +
                "Library Name: {0}\n" +
                "Street: {1}\n" +
                "City: {2}\n" +
                "State: {3}\n" +
                "Zip: {4}\n" +
                "Books: {5}\n",
                LibraryName, StreetAddress, City, State, Zip, bookCount
                );
        }
    }//end class
}
