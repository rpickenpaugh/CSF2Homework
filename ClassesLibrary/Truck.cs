using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
   public class Truck : Vehicle
    {
        public float LoadCapacityLbs { get; set; }

        public Truck(string make, string model, int year, float weight, float loadCapacityLbs):base(make, model, year, weight)
        {
            LoadCapacityLbs = loadCapacityLbs;
        }
        public Truck()
        {

        }
        public override string ToString()
        {
            return string.Format("{0}Load Capacity Lbs: {1:n0}\n",
                base.ToString(),
                LoadCapacityLbs);
        }
    }//end class
}
