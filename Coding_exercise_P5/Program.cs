using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_exercise_P5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string normal = ("Hello World");
            char [] reverse = normal.ToCharArray(); // ToCahrArray creates a copy of the characters in specified substring
            Array.Reverse(reverse);                 // Array.Reverse - reverse the array in a one dimension (reverse the characters)
            Console.WriteLine(normal);
            Console.WriteLine(reverse);
            Console.ReadLine();

        }
    }
}
