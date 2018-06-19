using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public string Get(int num)
        {
            if (IsMultipleOf3and5(num))
            {
                return "FizzBuzz";
            }
            if (IsMultipleOf3(num))
            {
                return "Fizz";
            }
            if (IsMultipleOf5(num))
            {
                return "Buzz";
            }

            return num.ToString();
        }
        
        //Get property

        private bool IsMultipleOf3and5(int numberToCheck)
        {
            return numberToCheck % 5 == 0 && numberToCheck % 3 == 0;
        }

        private bool IsMultipleOf3(int numberToCheck)
        {
            return numberToCheck % 3 == 0;
        }

        private bool IsMultipleOf5(int numberToCheck)
        {
            return numberToCheck % 5 == 0;
        }


    }//class

}//namespace
