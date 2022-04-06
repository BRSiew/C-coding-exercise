using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_return_the_square_of_a_given_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 2;

            sum = Math.Pow(sum, 2.0);
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
