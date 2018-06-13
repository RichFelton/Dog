using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter2
{
    class PetTypeAndDiet : VirtualPet
    {
        private string typeOfPet;
        private string dietOfPet;

        public string TypeOfPet { get; set; }
        public string DietOfPet { get; set; }

        public PetTypeAndDiet() //default constructor
        {
                
        }

        public PetTypeAndDiet(string typeOfPet, string dietOfPet) //loaded constructor
        {
            TypeOfPet = typeOfPet;
            DietOfPet = dietOfPet;

        }

        public List<string> petType = new List<string>() { "dog", "dog", "dog", "dog", "dog" };
        public List<string> foodType = new List<string>() { "dog food", "dog food", "dog food", "dog food", "dog food" };

    }
}
