using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Calc
    {
        public Calc()
        {
            Func<double, double, double> add = (x, y) => x + y;
            Func<double, double, double> divide = (x, y) => x / y;
            Func<double, double, double> subtract = (x, y) => x - y;
            Func<double, double, double> multiply = (x, y) => x * y;

            Console.WriteLine("Press 1 for Add, 2 for Divide, 3 for Subtract and 4 for Multiply");
            double input = 0, x = 0, y = 0, output = 0;
            try
            {
                input = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter X: ");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Y: ");
                y = double.Parse(Console.ReadLine());
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            switch (input)
            {
                case 1:
                    output = Perform(add, x, y); break;
                case 2:
                    output = Perform(divide, x, y); break;
                case 3:
                    output = Perform(subtract, x, y); break;
                case 4:
                    output = Perform(multiply, x, y); break;
                default:
                    Console.WriteLine("Invalid Input"); break;
            }
            Console.WriteLine($"Output= {output}");

        }

        public double Perform(Func<double, double, double> action, double x, double y) 
        {
            return action(x, y);
        }
       
    }
}
