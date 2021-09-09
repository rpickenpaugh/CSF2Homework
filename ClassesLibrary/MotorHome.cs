using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class MotorHome : Vehicle
    {
        //fields

        //properties
        public int NumberOfBeds { get; set; }

        //constructors
        public MotorHome(string make, string model, int year, float weight, int numberOfBeds) : base(make, model, year, weight)
        {
            NumberOfBeds = numberOfBeds;
        }
        public MotorHome()
        {

        }
        //methods

        public override string ToString()
        {
            return base.ToString() + "Number Of Beds: " + NumberOfBeds +"\n";
        }

    }//end class
}
