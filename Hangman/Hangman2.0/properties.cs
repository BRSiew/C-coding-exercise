using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman2._0
{
    internal class properties
    {
        // method to print the man
        public static void figureBuilder(int n)
        {
            int incorrectAttemptCounter = n;

            switch (incorrectAttemptCounter)
            {
                case 1:
                    Console.WriteLine("            __________");
                    Console.WriteLine("            |        |");
                    Console.WriteLine("            O        |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                    /|");
                    Console.WriteLine("                   / |");
                    Console.WriteLine("    ------------------");
                    break;
                case 2:
                    Console.WriteLine("            __________");
                    Console.WriteLine("            |        |");
                    Console.WriteLine("            O        |");
                    Console.WriteLine("           /         |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                    /|");
                    Console.WriteLine("                   / |");
                    Console.WriteLine("    ------------------");
                    break;
                case 3:
                    Console.WriteLine("            __________");
                    Console.WriteLine("            |        |");
                    Console.WriteLine("            O        |");
                    Console.WriteLine("           /|        |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                    /|");
                    Console.WriteLine("                   / |");
                    Console.WriteLine("    ------------------");
                    break;
                case 4:
                    Console.WriteLine("            __________");
                    Console.WriteLine("            |        |");
                    Console.WriteLine("            O        |");
                    Console.WriteLine("           /|\\      |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                    /|");
                    Console.WriteLine("                   / |");
                    Console.WriteLine("    ------------------");
                    break;
                case 5:
                    Console.WriteLine("            __________");
                    Console.WriteLine("            |        |");
                    Console.WriteLine("            O        |");
                    Console.WriteLine("           /|\\      |");
                    Console.WriteLine("           /         |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                    /|");
                    Console.WriteLine("                   / |");
                    Console.WriteLine("    ------------------");
                    break;
                case 6:
                    Console.WriteLine("            __________");
                    Console.WriteLine("            |        |");
                    Console.WriteLine("            O        |");
                    Console.WriteLine("           /|\\      |");
                    Console.WriteLine("           / \\      |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                    /|");
                    Console.WriteLine("                   / |");
                    Console.WriteLine("    ------------------");
                    break;
                default:
                    Console.WriteLine("            __________");
                    Console.WriteLine("            |        |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                    /|");
                    Console.WriteLine("                   / |");
                    Console.WriteLine("    ------------------");
                    break;
            }
            return;
        }
            
    }
}
