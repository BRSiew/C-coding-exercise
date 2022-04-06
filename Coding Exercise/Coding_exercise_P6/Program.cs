using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_exercise_P6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type a word: ");                      // change words here when on console (madam, step on no pets, book)
            string normal = Console.ReadLine();          
            char[] reverse = normal.ToCharArray(); // ToCahrArray creates a copy of the characters in specified substring
            Array.Reverse(reverse);                 // Array.Reverse - reverse the array in a one dimension (reverse the characters)
            string rev = new string(reverse);       // change the char to string
            bool result = normal.Equals(rev);       // create a boolean to comare string
            Console.WriteLine($"{(result ? $"'{normal}' is a palindrome." : $"'{normal}' is not a palindrome.")} ");
            Console.ReadKey();            // makes it so it exits console after pressing a key when code is finished
        }
    }
}
