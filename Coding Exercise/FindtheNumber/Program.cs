using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindtheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int numGen = rand.Next(1, 99);

            for (int i = 0; i <= 6; i++)
            {
                Console.Write("");
                int Guess = int.Parse(Console.ReadLine());

                if (Guess < numGen)
                {
                    Console.WriteLine("Higher");
                }
                if (Guess > numGen)
                {
                    Console.WriteLine("Lower");
                }
                if (Guess == numGen)
                {
                    Console.WriteLine($"Correct anwswer is {numGen}");
                    break;
                }
                if (i == 6 && Guess != numGen)
                {
                    Console.WriteLine($"Fail answer is: {numGen}");
                }
            }
            Console.ReadKey();
        }
    }
}
