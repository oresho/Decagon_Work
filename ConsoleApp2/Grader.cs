using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Grader
    {
        public void GetGrades()
        {
            char[] grades = ['A', 'B', 'C', 'D', 'E', 'F'];
            Console.Write("Input your score: ");
            int score = int.Parse(Console.ReadLine());


            if(score > 100 || score < 0) 
            { 
                Console.WriteLine("Invalid Entry");
            }
            else if (score >= 70)
            {
                Console.WriteLine("Grade is " + grades[0]);
            }
            else if (score >= 60)
            {
                Console.WriteLine("Grade is " + grades[1]);
            }
            else if (score >= 50)
            {
                Console.WriteLine("Grade is " + grades[2]);
            }
            else if (score >= 45)
            {
                Console.WriteLine("Grade is " + grades[3]);
            }
            else if (score >= 40)
            {
                Console.WriteLine("Grade is " + grades[4]);
            }
            else
            {
                Console.WriteLine("Grade is " + grades[5]);
            }
        }
    }
}
