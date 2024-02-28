using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2 
{
    internal class Fibonacci
    {
        public void PrintFib(int prevNum, int currNum, int limit) { 
            Console.WriteLine(prevNum);
            int sum = currNum + prevNum; 
            if (sum > limit) { return; }
            PrintFib(currNum, sum, limit);
        }

        public void FibPrint(int prevNum, int currNum, int limit)
        {
            int sum = 0;
            Console.WriteLine(prevNum);
            Console.WriteLine(currNum);
            for (int i = 0; sum < limit; i++)
            {
                sum = currNum + prevNum;
                Console.WriteLine(sum);
                prevNum = currNum;
                currNum = sum;
            }
        }
    }
}
