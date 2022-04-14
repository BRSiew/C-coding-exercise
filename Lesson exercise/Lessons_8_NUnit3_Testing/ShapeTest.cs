using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Lessons_8_NUnit3_Testing
{
    [TestFixture]
    internal class ShapeTest
    {
        [Test]
        public void rectangleTest()
        {
            AreaAndPerimeter rec = new AreaAndPerimeter();
            double width = 4.0;
            double height = 5.0;

            double Area = 20.0;
            double Perimeter = 18;
            double actualPerimeter = rec.rectanglePerimeter(width, height);
            double actualArea = rec.rectangleArea(width, height);
            Assert.That(Area, Is.EqualTo(actualArea));
            Assert.That(Perimeter, Is.EqualTo(actualPerimeter));
        }

        [Test]
        public void circleTest()
        {
            AreaAndPerimeter circ = new AreaAndPerimeter();
            double radius = 4.0;


            double Area = 50.26;
            double Perimeter = 25.13;
            double actualPerimeter = circ.circlePerimeter(radius);
            double actualArea = circ.circleArea(radius);
            Assert.That(Area, Is.EqualTo(actualArea).Within(1).Percent);
            Assert.That(Perimeter, Is.EqualTo(actualPerimeter).Within(1).Percent);
        }

        [Test]
        public void triangleTest()
        {
            AreaAndPerimeter tri = new AreaAndPerimeter();
            double sideA = 5.0;
            double sideB = 5.0;
            double sideC = 5.0;

            double Area = 10.83;
            double Perimeter = 15;
            double actualPerimeter = tri.trianglePerimeter(sideA, sideB, sideC);
            double actualArea = tri.triangleArea(sideA, sideB, sideC);
            Assert.That(Area, Is.EqualTo(actualArea).Within(1).Percent);
            Assert.That(Perimeter, Is.EqualTo(actualPerimeter));
        }

    }
}
