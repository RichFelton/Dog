using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Reptile dragonLizard = new Reptile(140, 226, "Herman", "Spain", true);

            Mammal bear = new Mammal(96.4, 480, "Smoky", "Montana", true);

            Console.WriteLine(bear.Sum());

            dragonLizard.GetInfo();

            Mammal wildCat = new Mammal(74, 193, "Willy", "Kansas State", true);

            wildCat.GetInfo();

            Console.WriteLine();

            Console.WriteLine(dragonLizard.GetWeight(0));

            Console.WriteLine(bear.GetWeight(100));
        }
       
        
    }
}
