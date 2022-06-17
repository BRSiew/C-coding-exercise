using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcHttpClient
{
    internal class Arith : ICalc
    {
        public int Add(int start, int amount)
        {
            return start + amount;
        }

        public double Divide(double start, double by)
        {
            return start / by;
        }

        public int Multiply(int start, int by)
        {
            return start * by;
        }

        public int Subtract(int start, int amount)
        {
            return start - amount;
        }
    }
}
