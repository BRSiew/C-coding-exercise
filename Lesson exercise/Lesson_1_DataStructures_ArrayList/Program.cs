using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Lesson_1_DataStructures_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double average;
            int grade = 0;
            int total = 0;
            int highest = 0;
            Random r = new Random(); // creates a random number 
            // creates an array list
            ArrayList grades = new ArrayList(); // can also use List<>
            for (int x = 0; x < 10; x++)
            {
                //generate grade and add to arrayList
                
                grade = r.Next(0, 100); // random number from 0 -100
                 grades.Add(grade);
            }
            for (int i = 0; i < grades.Count; i++)
            {
                Console.WriteLine($"grades[{i}] = {grades[i]}");
                total += (int) grades[i];   //have to put (int) before to indicate integer when using ArrayList
                if((int) grades[i] > highest)
                {
                    highest = (int) grades[i];
                }
            }
            average = total / grades.Count;
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"Highest grade is: {highest}");
            Console.ReadLine();

        }
    }
}
