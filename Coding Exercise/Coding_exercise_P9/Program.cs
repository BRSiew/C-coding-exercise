using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_exercise_P9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool prime = true; // boolean
            
            int count = 0;
            List<int> number = new List<int>(); // creating a list for prime numbers
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= 100; j++)
                {
                    if (i != j && i % j == 0)   //counter of i and j cannot be the same and the counter i modulus of j  must equal 0
                    {
                        prime = false;          // states that this condiontion is false and not prime numbers
                        break;                  // stop and terminate loop move to next loop
                    }
                }
                if (prime)      // condition is if prime
                {
                    
                    List<int> PrimeNumber = new List<int> { i };
                    for(int x = 0; x < PrimeNumber.Count; x++) // create a list of all numbers of prime number
                    {
                        
                        //Console.WriteLine($"{PrimeNumber[x]}");     // 
                       // Console.Write("Number:  ");                      // type numbers to get a string 
                       // var num = int.Parse(Console.ReadLine()); // converts string representation to number
                        int num = 5;    // type number here
                        count++;
                        if (count== num)
                        {
                            
                            Console.WriteLine($" The {num}th prime number is {PrimeNumber[x]}");
                        }

                    }
                }
                prime = true;
                    

            }
            
            Console.ReadKey();
        }
    }
}
