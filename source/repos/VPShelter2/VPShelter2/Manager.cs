using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter2
{
    class Manager : Employee
    {
        public new double Hours { get; private set; }

        public double PayBills { get; set; }

        //VirtualPetShelter petList RemoveAt();

        public override double Hours()
        {
            double totalHours = tHours;
        }

        public override double PayRate()
        {
            double payRate = 35.75;
            double totalPay = totalHours * payRate;
        }
    }
}
