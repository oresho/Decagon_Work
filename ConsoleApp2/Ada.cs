using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Ada
    {
        public void MyMethod() 
        {
            string[] names = { "fred", "wini", "adaeze","ore balogun","banke bank"};
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == "adaeze") 
                {
                    Console.WriteLine(names[i]);
                }        
            }
        }

        public string GetName(string name)
        {
            return name;
        }
    }
}
