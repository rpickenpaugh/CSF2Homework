using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Vehicle
    {
        //fields
        
        //properties

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public float Weight { get; set; }

        //constructors

        public Vehicle(string make, string model, int year, float weight)
        {
            Make = make;
            Model = model;
            Year = year;
            Weight = weight;
        }
        public Vehicle()
        {

        }

        //methods

        public override string ToString()
        {
            return string.Format("Make: {0}\n" +
                "Model: {1}\n" +
                "Year: {2}\n" +
                "Weight: {3:n0}\n",
                Make, Model, Year, Weight);
        }
    }//end class
}
