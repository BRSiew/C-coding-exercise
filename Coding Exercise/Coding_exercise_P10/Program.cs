using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_exercise_P10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prime prime = new Prime(); //instantiating class
            Console.Write("Original number: ");
            var num = int.Parse(Console.ReadLine());
            if (num == prime.PrimeNumber(num)) // for the next prime number if number is a prime number
            {
                num++;
                Console.WriteLine($"next prime number: {prime.PrimeNumber(num)}");
            }
            else
            {
                Console.WriteLine($"next prime number: {prime.PrimeNumber(num)}");
            }
            Console.ReadKey();
        }
    }
}
