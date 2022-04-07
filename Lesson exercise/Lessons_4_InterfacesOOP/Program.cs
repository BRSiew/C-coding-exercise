using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_4_InterfacesOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle(); // instanciate rectangle class
            Circle circle = new Circle();   // instanciate circle class
            Triangle tri = new Triangle(); // instanciate triangle class

            double a = 10;
            double b = 20;
            double c = 20.0;
            double area = 0.0;
            double perimeter = 0.0;
            rec.height = a;
            rec.width = b;
            area = rec.Area();
            Console.WriteLine($"Area of rectangle is : {area}");
            perimeter = rec.perimeter();
            Console.WriteLine($"Perimeter of rectangle is : {perimeter}");
            //Console.ReadLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Circle area and perimeter");
            circle.radius = c;
            area = circle.Area();
            Console.WriteLine($"Area of a circle is : {area}");
            perimeter = circle.perimeter();
            Console.WriteLine($"Permeter of a circle is : {perimeter}");
            //Console.ReadLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("triangle area and perimeter");
            tri.sideA = a;
            tri.sideB = b;
            tri.sideC = c;  
            area = tri.Area();
            Console.WriteLine($"Area of a triangle is : {area}");
            perimeter = tri.perimeter();
            Console.WriteLine($"Permeter of a triangle is : {perimeter}");
            Console.ReadLine();
        }
    }
}
