using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_8_NUnit3_Testing
{
    internal class Shapes
    {
        // circle
        public double radius { get; set; } // get and set radius in main method

        // rectangle
        public double height { get; set; } // get and set height in main method 'Properties'
        public double width { get; set; }   // get and set width in main method 'properties'

        //triangle
        public double sideA { get; set; }
        public double sideB { get; set; }
        public double sideC { get; set; }
    }
}
