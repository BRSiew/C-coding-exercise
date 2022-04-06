using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_exercise_P10
{
    public class Prime
    {
        public int PrimeNumber(int n)   // getting next prime number
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) // number is divisible
                { 
                    n++;        // n = n+1
                    i = 2;      // reset to 2
                }
            }
            return n;
        }
    }
    
}