using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_exercise_P2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            List<string> starList = new List<string>();
            starList.Add("parts");
            starList.Add("traps");
            starList.Add("arts");
            starList.Add("rats");
            starList.Add("starts");
            starList.Add("tarts");
            starList.Add("rat");
            starList.Add("art");
            starList.Add("tar");
            starList.Add("tars");
            starList.Add("stars");
            starList.Add("stray");

            var star = from word in starList
                 where word.Length == 4
                 select word;


            Console.WriteLine(string.Join(",",star));
            Console.ReadLine();


        }
    }
}
