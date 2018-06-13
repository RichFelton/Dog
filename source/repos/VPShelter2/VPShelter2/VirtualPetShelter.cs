using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter2
{
    class virtualPetShelter
    {
        private string listOfPets;
        private string listOfEmployees;


        public string ListOfPets { get; set; }
        public string ListOfEmployees { get; set; }
        public List<string> PetList { get; set; }

        public virtualPetShelter() //default constructor
        {

        }

        public virtualPetShelter(string listOfPets, string listOfEmployees)
        {
            ListOfPets = listOfPets;
            ListOfEmployees = listOfEmployees;
        }
        public List<string> petList = new List<string>() { "Matrix", "Ally", "Rickie", "Carrie", "Bayly" };

        public List<string> employeeList = new List<string>() { "Courtney", "John", "Mallory", "Michael", "Hope", "Pete" };



    }
}
