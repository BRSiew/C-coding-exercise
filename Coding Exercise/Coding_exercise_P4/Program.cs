using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_exercise_P4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> StarDiamond = new List<string>();
            StarDiamond.Add("    *");
            StarDiamond.Add("   ***");
            StarDiamond.Add("  *****");
            StarDiamond.Add(" *******");
            StarDiamond.Add("*********");
            StarDiamond.Add(" *******");
            StarDiamond.Add("  *****");
            StarDiamond.Add("   ***");
            StarDiamond.Add("    *");
            Console.WriteLine(string.Join("\n", StarDiamond)); //\n - creates a vertical space between each string
            Console.ReadLine();
        }
    }
}
