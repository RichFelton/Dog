using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumberTutoring
{
    public class //Class1
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a starting number: ");
            int minNumber = int.Parse(Console.ReadLine());

            Console.Write("Please enter an ending number: ");
            int maxNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(minNumber + "" + maxNumber);

            int[] userNum = new int[6];

            Console.WriteLine("Please enter six numbers");

            for(int i = 0; i < userNum.Length; i++)
            {
                userNum[i] = int.Parse(Console.ReadLine());

            }

        }
    }
}
