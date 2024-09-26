using PrimeNumber.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(CheckingPrime.ToCheckPrime(number) 
                ? $"{number} is Prime" : 
                $"{number} is not a Prime");

        }
    }
}
