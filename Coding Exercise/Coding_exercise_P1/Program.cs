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
            for (int i = 0; i < Sales.Length; i++)      // counting each value
            {
                if (Sales[i] == 0)      // condition that the value must be zero
                {
                    count++;            // each time the value is 0 the counter goes up
                    if (value < count)  // value will take on the value of count if count is greater than value
                    {
                        value = count;  // the highest value will be the last value that appears on the list
                    }
                }
                else
                {
                    count = 0;          // each time the value is not zero reset counter to 0
                }  
                Console.WriteLine($"Longest sequence of days without sales: {value}"); // last value is the longest sequence of days without sales
            }           
            Console.ReadLine();

        }
    }
}
