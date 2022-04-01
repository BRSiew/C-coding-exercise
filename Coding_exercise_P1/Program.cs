using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_exercise_P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int count = 0;
            int value = 0;


            int [] Sales = { 1, 2, 1, 1, 0, 3, 1, 0, 0, 0, 0, 2, 1, 0, 3, 1, 0, 0, 0, 6, 1, 3, 0, 0, 0 };
            for (int i = 0; i < Sales.Length; i++)
            {
                if (Sales[i] == 0)
                {
                    count++;
                    if (value < count)
                    {
                        value = count;
                    }
                }
                else
                {
                    count = 0;
                }  
                Console.WriteLine($"Longest sequence of days without sales: {value}"); // last value is the 
            }           
            Console.ReadLine();

        }
    }
}
