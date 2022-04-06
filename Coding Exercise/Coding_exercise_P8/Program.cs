using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_exercise_P8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int>();
            number.Add(3);
            number.Add(1);
            number.Add(5);
            number.Add(7);
            number.Add(5);
            number.Add(9);
            int goal = 10; 

            for (int i = 0; i < (number.Count/2); i++) // goes through half the numbers in the list so values does not repeat can remove /2 for whole list
            {
                for (int j = 0; j < number.Count; j++) //goes through each number for each value of i
                {
                    int sum = number[i] + number[j];    // sum of the two values
                    var tuple = new Tuple<int, int>(i, j);  // creates a Tuple of the positions of te list
                    if (number[i] + number[j] == goal && i != j)    // condition that the two vales have to equal 10 and postions i and j are not the same
                    {
                        Console.WriteLine($"({tuple.Item1},{tuple.Item2}) or ({tuple.Item2},{tuple.Item1}), two sum is: {number[i]} + {number[j]} = {sum}");
                    }
                    else if (number[i] + number[j] != goal && i != j)   //condition if numbers do not equal 10
                    {
                        Console.WriteLine($"({tuple.Item1},{tuple.Item2}), {number[i]} and {number[j]} are null");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
