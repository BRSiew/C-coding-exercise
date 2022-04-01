using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instantiate the class and create object
            Calculator calc = new Calculator();
            Calculator_subtract calc_sub = new Calculator_subtract();
            Calculator_multiply calc_mul = new Calculator_multiply();
            Calculator_division calc_div = new Calculator_division();
            //Create a local variable to hold the answer
            int x = 8;
            int y = 5;
            int sum = 0;
            sum = calc_sub.Subtract(x, y);    //Add, Subtract, Multiply, Division
            Console.WriteLine("sum of {0} + {1} = {2}", x, y, sum);
            Console.ReadLine();
        }
    }
}
