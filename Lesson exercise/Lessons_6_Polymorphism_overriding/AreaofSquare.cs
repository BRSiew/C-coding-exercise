using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_6_Polymorphism_overriding
{
    internal class AreaofSquare
    {
        public virtual double Square(double a, double b)
        {
            Console.WriteLine("Calculate area of a square power a^2");
            return Math.Pow(a, 2);
        }
    }
}
