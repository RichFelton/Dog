using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int count = 0;
            VirtualPetShelter virtualPetShelter = new VirtualPetShelter();
            PetTypeAndDiet petTypeAndDiet = new PetTypeAndDiet();

            Console.Write("Welcome to the We Can Code IT Virtual Pet Shelter \n");

            Console.WriteLine();


            Console.WriteLine("These are the current pets in residence and their status: \n");

            Console.WriteLine("{0, -10} {1, -10} {2, -10} {3, -20}{4, -13} {5, -10} \n", virtualPetShelter.columnHeaders);
            foreach (var item in virtualPetShelter.petList)
            {   count++;
                Random foodStatus = new Random(count);
                int food = foodStatus.Next(0, 11);
                food++;
                Random thirstStatus = new Random(food);
                int water = thirstStatus.Next(0, 11);
                water++;
                Random toiletStatus = new Random(water);
                int peeOrPoop = toiletStatus.Next(0, 11);

                Console.WriteLine("{0, -12} {1, -10} {2, -15} {3, -15}", item, food, water, peeOrPoop + "              dog   " + "    dog food     ");
            }

            int userInput = 0;
            string userName = "";

            Console.Write("\n Manager or volunteer, please enter your first name: ");
            userName = Console.ReadLine();
            Console.WriteLine("Please select the number of the activity you would like to perform: ");
            Console.WriteLine("[1] Review status of the pets.");
            Console.WriteLine("[2] Play with a pet.");
            Console.WriteLine("[3] Remove a pet for adoption.");
            Console.WriteLine("[4] Pay the bills.");
            Console.WriteLine("[5] return");
            Console.ReadLine();


            userInput = int.Parse(Console.ReadLine());

            do
            {
                switch (userInput)
                {

                    case 1: //Review status of the pets.
                        Console.Write(userName + ", select [1] to review status; select [2] to return: \n ");
                        Console.WriteLine("[1] Review status of the pets.");
                        Console.WriteLine("[2] Return to previous menu.");
                        int careForPet = int.Parse(Console.ReadLine());
                        break;
                    case 2: //Play with a pet
                            //int index = 0;
                        Console.WriteLine("Select the pet you would like to play with: \n");
                        foreach (var item in virtualPetShelter.petList)
                        {
                            Console.WriteLine(item);
                        }




                        Console.WriteLine("You have just played with " + virtualPetShelter.ListOfPets[userInput]);
                        break;
                    case 3: // Coordinate pet adoption
                        Console.WriteLine("Select the pet you would like to play with: \n");
                        
                        break;

                    case 4: //Pay the bills 
                        Console.WriteLine("You have chosen to pay all outstanding bills: ");
                        Console.WriteLine("All the outstanding bills have been paid. ");
                        break;

                    case 5: //Return to previous menu
                        break;
                    default:
                        Console.WriteLine("Invalid response!");
                        break;
                }

            } while (userInput == 0);
     

            } //main
        } //class
    } //namespace
