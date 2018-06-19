using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Mammal : Species
    {
        public Mammal(double height, double weight, string name, string habitat, bool hasTail)
        {
            this.Height = height;
            this.Weight = weight;
            this.Name = name;
            this.Habitat = habitat;
            this.HasTail = hasTail;

        }


        public Mammal()
        {

        }

        public override double GetWeight(double num)
        {
            num = num + Weight;
            return num;
        }
    }
}
