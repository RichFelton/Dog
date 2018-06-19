using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Species
    {
        //private double weight;
        //private double height;
        //private string name;
        //private string habitat;
        //private bool hasTail;

        public double Weight { get; set; } //This is in lieu of private double weight;
        public double Height { get; set; }
        public string Name { get; set; }
        public string Habitat { get; set; }
        public bool HasTail { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine("{0} is {1} pounds and {2} inches tall and lives in {3}", Name, Weight, Height, Habitat);

        }
        public double Sum()
        {
            double sum = Weight + Height;
            return sum;
        }

        public virtual double GetWeight(double num)
        {
            return Weight;
        }

    }
}
