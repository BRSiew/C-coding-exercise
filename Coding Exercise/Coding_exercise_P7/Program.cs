using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_exercise_P7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("");                      // type numbers to get a string
            int number = int.Parse(Console.ReadLine()); // converts string representation to number
            int sum = 0, remainder;

            while (number != 0)         // while number does not = 0
            {
                remainder = number % 10;    // gets the modulus of the number example 9%2 = 1 since 2*4 = 8 and 9-8 =1
                sum = sum + remainder;
                number /= 10;               // since its int the number will be rounded therefore no decimal
            }
           
            Console.WriteLine($"The Sum of Digits is : {sum}");
            Console.ReadKey();
        }
    }
}
