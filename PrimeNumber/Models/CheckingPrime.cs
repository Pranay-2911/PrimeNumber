using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber.Models
{
    internal class CheckingPrime
    {
        public static bool ToCheckPrime(int number)
        {
            int minValue = 0;
            int exception = 1;
            //Check Exception 
            if (number <= exception) return false;

            //Check prime number From 2 to Number
            for (int i = 2; i < number; i++)
            {
                //if i divde number completely then return false
                if (number % i == minValue)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
