using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter2
{
    abstract class Employee
    {
        protected Employee() //default constructor
        {
        }

        private string PhoneNumber { get; set; }

        public abstract double PayRate();

        public abstract double Hours();
    }
}
