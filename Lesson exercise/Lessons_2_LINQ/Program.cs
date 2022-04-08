using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_2_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string likes = "I like fruit";
            string[] fruits = { "Orange", "Apple", "Grapefruit", "Pear", "Pineapple", "Grapes", "Peach", "Melon", "Coconut" };
            int[] numbers = { 5, 6, 3, 8, 2, 9, 1, 6, 15, 66, 34, 23, 32, 45, 29, 30 };
            var getNumbers = from number
                             in numbers
                             where number <10
                             select number;
            Console.WriteLine(string.Join(",", getNumbers));
            Console.WriteLine("----------------");
            var evenNumbers = from number
                             in numbers
                             where number%2 == 0 //where number is a multiple of 2 
                             select number;
            Console.WriteLine("Even numbers are: " + string.Join(",", evenNumbers));
            Console.WriteLine("----------------");
            var letterG = from fruit in fruits
                          where fruit.Contains("G") && (fruit.Length < 8)
                          select fruit;
            Console.WriteLine(string.Join(", ", letterG));
            Console.ReadLine();
        }
    }
}
