using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_8_NUnit3_Testing
{
    internal class AreaAndPerimeter : Shapes
    {

        public double rectangleArea(double width, double height)
        {
            return width * height;
            
        }

        public double rectanglePerimeter(double width, double height)
        {
            return 2 * height + 2 * width;
        }

        public double circleArea( double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double circlePerimeter(double radius)
        {
            return 2 * Math.PI *  radius;
        }

        public double triangleArea(double sideA, double sideB, double sideC)
        {
            double s = (sideA + sideB + sideC) / 2;
            return Math.Sqrt((s * (s - sideA) * (s - sideB) * (s - sideC))); //area with all sides known
        }
        public double trianglePerimeter(double sideA, double sideB, double sideC)
        {
            return sideA + sideB + sideC;
        }

    }
}
