using System;

namespace ConsoleApp2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Filer filer = new Filer();            
        }

        public void dels()
        {
            Delegating delegating = new Delegating();
            Func<int, int, double> sum = delegate (int x, int y) {
                return (double)x + y;
            };
            delegating.TestMyDelegate(sum, 4, 55);

            var list = new List<string>() { "ore", "abike", "ada" };
            var f = list.FirstOrDefault(x => x == "abike");
            Console.WriteLine(f);

            Func<List<string>, string, string> search = delegate (List<string> list, string term)
            {
                foreach (var item in list)
                {
                    if (item == term)
                    {
                        return item;
                    }
                }
                return null;
            };

            Console.WriteLine(search(list, "ada"));
        }

    }
}