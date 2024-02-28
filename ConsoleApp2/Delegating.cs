using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Delegating
    {
        public delegate void Print(string str);
        public string FirstOrDefault(Func<List<string>, string, string> search, List<string> list, string term) 
        {
           return search(list, term);
        }

        public void TestMyDelegate(Func<int, int, double> sum, int x, int y)
        {
            Console.WriteLine(sum(x, y));
        }
    }
}
