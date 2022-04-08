using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_String_Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder test = new StringBuilder("hello world", 50); //creates a string builder, number is space capacity

            //iteration 
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(test);//output Hello world 5 times
            }
            Console.WriteLine("--------------");

            var greet = test.ToString(); //Converts to string
            Console.WriteLine(greet + " - StringBuilder are not strings therefore .ToString() converts it to one");

            Console.WriteLine("--------------------");

            Console.WriteLine("Adding or appending strings in StringBuilder");
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello "); //add Hello and next string will continue on
            sb.AppendLine("World"); // Add World after Hello. Next string will be a new line
            sb.AppendLine("in C#");
            Console.WriteLine(sb);
            Console.WriteLine("--------------------");

            Console.ReadLine();
        }
    }
}
