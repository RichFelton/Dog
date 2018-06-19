using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string userResp = " ";
            Console.WriteLine("Would you like to play?");
            Console.Write("Please enter Yes to play: ");
            userResp = Console.ReadLine().ToLower();
                int jackPot = 100000;
                int numMatches = 0;
                Console.Write("Please enter a starting number: ");
                int minNumber = int.Parse(Console.ReadLine());

                Console.Write("Please enter an ending number: ");
                int maxNumber = int.Parse(Console.ReadLine());

                Console.WriteLine(minNumber + "" + maxNumber);

                int[] userNum = new int[6];

                Console.WriteLine("Please enter six numbers");

            for (int i = 0; i < userNum.Length; i++)
            {

                int inputTest = int.Parse(Console.ReadLine());

                while (inputTest < minNumber || inputTest > maxNumber)
                {
                    Console.WriteLine("Please enter a value greater than {0} and less than {1} ", minNumber, maxNumber);

                    inputTest = int.Parse(Console.ReadLine());
                }
                userNum[i] = inputTest;

                //Console.WriteLine(userNum[i]);

                int[] randArray = new int[6];
                Random r = new Random();

                for (int j = 0; j < randArray.Length; j++)
                {
                    randArray[j] = r.Next(minNumber, maxNumber);
                    Console.WriteLine("Lucky Number: {0}", randArray[j]);

                }

                Console.WriteLine("Jackpot amount is {0}", jackPot);

                for (int k = 0; k < userNum.Length; k++)
                {
                    for (int l = 0; 1 < randArray.Length; l++)
                    {
                        if (userNum[k] == randArray[l])
                        {
                            numMatches++;
                            break;
                        }
                    }
                }

                Console.WriteLine("You guess {0} numbers correctly", numMatches);
                Console.WriteLine("You won {0} dollars", jackPot / numMatches);
                Console.WriteLine("Would you like to play again?");
                Console.Write("Please enter Yes to play again: ");
                userResp = Console.ReadLine().ToLower();
            }
            }//Main
    }//class
}//namespace
