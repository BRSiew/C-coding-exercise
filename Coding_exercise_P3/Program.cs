using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_exercise_P3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> StarTree = new List<string>();
            StarTree.Add("    *");                      // created intentional spaces to form the shape
            StarTree.Add("   ***");
            StarTree.Add("  *****");
            StarTree.Add(" *******");
            StarTree.Add("*********");
            Console.WriteLine(string.Join("\n", StarTree)); //\n - creates a vertical space between each string
            Console.ReadLine();
        }
    }
}
