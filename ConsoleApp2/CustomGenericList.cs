using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class CustomGenericList<T> 
    {
        public required List<T> List { get; set; }
        public required List<T> values = [];
        public required List<T> keys = [];

        public void Add(T item) { 
            if (item != null)
            {
                List.Add(item);
            }
        }

        public void Clear()
        {
            List.Clear();
        }

        public bool Contains(T item) {  return List.Contains(item); }

        public bool ContainsKey(T item)
        {
            foreach(T value in values) { 
                if(value.Equals(item)) return true;
            }
            return false;
        }
    }
}
