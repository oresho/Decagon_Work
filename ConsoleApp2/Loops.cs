using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Loops
    {
        public void PrintSevenEven()
        {
            int counter = 0;
            int i = 1;
            while (counter < 7)
            {
                if (i % 2 == 0)
                {
                    counter++;
                    Console.WriteLine(i);
                }
                i++;
            }
        }

        public void jun()
        {
            Person[] people =
            {
                new() { Id = 1, Name = "Ada" },
                new() { Id = 2, Name = "Ken" },
                new() { Id = 3, Name = "Banke" },
                new() { Id = 4, Name = "Max" },
                new() { Id = 5, Name = "Chris" },
                new() { Id = 6, Name = "Kiki" },
                new() { Id = 7, Name = "Ifeoma" },
                new() { Id = 8, Name = "Kenny" },
                new() { Id = 9, Name = "Samuel" },
                new() { Id = 10, Name = "Ore" },
            };

            //foreach (Person person in people)
            //{
            //    Console.WriteLine(person.Name);
            //}

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine(people[i].Name);
            }
        }


        public void PrintSevenOdd<T>(T data)
        {

        }
    }
}
