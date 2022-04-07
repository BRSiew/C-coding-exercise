using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_4_InterfacesOOP
{
    internal class Rectangle : IShape
    {
        public double height { get; set; } // get and set height in main method 'Properties'
        public double width { get; set; }   // get and set width in main method 'properties'
        public double Area()
        {
            return height * width;
        }

        public double perimeter()
        {
            return 2 * height + 2 * width;
        }
    }
}
