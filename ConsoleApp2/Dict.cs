using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Dict
    {
        public Dictionary<int, string> GetEngNumbersDict()
        {
            Dictionary<int, string> nums = new();
            nums.Add(1, "One");
            nums.Add(2, "Two");
            nums.Add(3, "Three");
            nums.Add(4, "Four"); 
            nums.Add(5, "Five");
            nums.Add(6, "Six");
            nums.Add(7, "Seven");
            nums.Add(8, "Eight");
            nums.Add(9, "Nine");
            nums.Add(10, "Ten");

            return nums;
        }

        public Dictionary<int, string> GetYorubaNumbersDict()
        {
            Dictionary<int, string> nums = new();
            nums.Add(1, "Okan");
            nums.Add(2, "Meji");
            nums.Add(3, "Meta");
            nums.Add(4, "Merin");
            nums.Add(5, "Marun");
            nums.Add(6, "Mefa");
            nums.Add(7, "Meje");
            nums.Add(8, "Mejo");
            nums.Add(9, "Mesan");
            nums.Add(10, "Mewa");

            return nums; 
        }

    }
}
