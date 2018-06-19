using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter2
{
    class VirtualPetShelter
    {
        private string listOfPets;
        private string listOfEmployees;


        public string ListOfPets { get; set; }
        public string ListOfEmployees { get; set; }
        public List<string> PetList { get; set; }

        public VirtualPetShelter() //default constructor
        {

        }

        public VirtualPetShelter(string listOfPets, string listOfEmployees)
        {
            ListOfPets = listOfPets;
            ListOfEmployees = listOfEmployees;
        }
        public List<string> petList = new List<string>() { "Matrix", "Ally", "Rickie", "Carrie", "Bayly" };

        public List<string> employeeList = new List<string>() { "Courtney", "John", "Mallory", "Michael", "Hope", "Pete" };

        public List<string> columnHeaders = new List<string>() { "Pet Name", "Hunger", "Thirsty", "Needs to go out", "Pet Type", "Food" };

        public override string ToString()
        {
            return String.Format("{0, -10} {1, -10} {2, -10} {3, -20}{4, -13} {5, -10} \n", this.columnHeaders);
        }

    }
}
