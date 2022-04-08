using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_4_InterfacesOOP
{
    internal class Triangle : IShape
    {
        public double sideA { get; set; }
        public double sideB { get; set; }
        public double sideC { get; set; }

        public double Area()
        {
            double s = (sideA + sideB + sideC) / 2;
            return Math.Sqrt((s * (s - sideA)* (s - sideB) * (s - sideC))); //area with all sides known

        }

        public double perimeter()
        {
            return sideA + sideB + sideC;
        }
    }
}
