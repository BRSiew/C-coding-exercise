using System;
using NUnit.Framework;
namespace Lessons_8_NUnit3_Testing
{
    [TestFixture]
    internal class CalcTest
    {
        
       
        
            [Test]
            public void AddTest()
            {
                Calc c = new Calc();
                double x = 4.0;
                double y = 5.0;

                double expectedValue = 9.0;
                double actualValue = c.Add(x, y);
                Assert.That(expectedValue, Is.EqualTo(actualValue));

            }

        [Test]
        public void SubtractTest()
        {
            Calc c = new Calc();
            double x = 8.0;
            double y = 5.0;

            double expectedValue = 3.0;
            double actualValue = c.Subtract(x, y);
            Assert.That(expectedValue, Is.EqualTo(actualValue));
        }
        
    }
}
