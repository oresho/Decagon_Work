using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Transaction
    {
        public int Id { get; set; }
        public string Action { get; set; }
        public double Amount { get; set; }
        public bool IsSuccessful { get; set; }
        public DateTime dateTime { get; set; }

        public Transaction(int Id, string Action, double Amount, bool isSuccessful)
        {
            this.Id = Id;
            this.Action = Action;
            this.Amount = Amount;
            this.dateTime = DateTime.Now;
            this.IsSuccessful = isSuccessful;
        }
    }
}
