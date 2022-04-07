using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_6_Polymorphism_overriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AreaofShapes areaSquare = new AreaofShapes();
            double a = 10;
            double b = 10;
            double area = 0;
            area = areaSquare.Square(a, b);
            Console.WriteLine($"area of square : {area}");
            Console.ReadLine();
        }
    }
}
