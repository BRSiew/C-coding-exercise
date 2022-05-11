using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_exercise_P9_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            primeNumber prime = new primeNumber();

            int count = 0;

            List<int> number = new List<int>();
            for (int i = 2; i < 100; i++)
            {
                int PN = prime.PrimeNumber(i);
                if (i == PN)
                {
                    number.Add(i);

                }
            }

            Console.Write("Please enter a number:  ");
            int num = int.Parse(Console.ReadLine());

            for (int j = 0; j < number.Count; j++)
            {

                count++;
                if (num == count)
                {
                    Console.WriteLine($"Prime number {num} is {number[j]}");
                }
            }
            Console.ReadLine();
        }
    }
}
