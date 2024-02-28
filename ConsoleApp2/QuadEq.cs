using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class QuadEq
    { 
        public double[] GetRoots(double a, double b, double c)
        {
            double D = Math.Pow(b, 2) - (4 * a * c);
            double x1;
            double x2;
            if (D < 0) { return []; }
            else if(D == 0) 
            {
                x1= x2 = -b / (2 * a); 
                return [x1, x2];
            }
            x1 = (-b + Math.Sqrt(D))/(2 * a);
            x2 = (-b - Math.Sqrt(D)) / (2 * a);
            return [x1, x2];
        }

        public void meth()
        {
            int[] numbers = [0, 1, 2, 3, 4];

            for (int i = 0; i <5; i++)
            {
                int temp = numbers[i] + 1;
            }

            int counter = 0;

            while (counter < 10)
            {


                counter++;
            }

            do 
            {
                counter++;
            } while (counter < 10);

            

            foreach (int i in numbers)
            {
                int temp = i;
            }
        }
    }
}
