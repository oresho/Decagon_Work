using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Bank
    {
        public static double SenderAccountBalance = 0;
        public static double ReceiverAccountBalance = 0;
        public static double BankBalance = 0;
        public static int Id = 1;
        public static List<Transaction> TransactionHistory = new List<Transaction>();

        public void Runner()
        {
            string[] funcs = ["Withdraw", "Deposit", "Transfer"];
            Console.WriteLine("Welcome to Ore's Bank!");
            while (true)
            {
                Console.WriteLine("Enter:\n1 for Withdrwal\n2 for Deposits\n3 for Transfer\n4 to get account balance\n5 to get your Transaction History");
                Console.Write("Input: "); int input = int.Parse(Console.ReadLine());
                if (input > 5 || input < 1) 
                { 
                    Console.WriteLine("Invalid Input, Sorry please enter a value from 1 to 5"); 
                    continue; 
                }
                double amount = 0;
                if (input < 4) 
                { 
                    Console.Write($"Enter Amount to {funcs[input-1]}: "); 
                    amount = double.Parse(Console.ReadLine()); 
                }
                switch (input)
                {
                    case 1:
                        Withdraw(amount);
                        break;
                    case 2:
                        Deposit(amount);
                        break;
                    case 3:
                        Transfer(amount);
                        break;
                    case 4:
                        PrintBalance();
                        break;
                    case 5:
                        GetTransactionHistory();
                        break;
                    default:
                        Console.WriteLine("Sorry please enter a value from 1 to 5");
                        break;
                }
            }
        }

        public void Deposit(double amount)
        {
            SenderAccountBalance += amount;
            BankBalance += amount;
            TransactionHistory.Add(new Transaction(Id, "Deposit", amount, true));
            Id++;
            Console.WriteLine("Deposit Succesful");
        }

        public void Withdraw(double amount)
        {
            if(amount > SenderAccountBalance) 
            {
                TransactionHistory.Add(new Transaction(Id, "Withdrawal", amount, false));
                Console.WriteLine("Withdrawal failed: Insufficient Funds");
                return;
            }
            SenderAccountBalance -= amount;
            BankBalance -= amount;
            TransactionHistory.Add(new Transaction(Id, "Withdrawal", amount, true));
            Id++;
            Console.WriteLine("Withdrawal Successful");
        }

        public void Transfer(double amount)
        {
            //if (amount > SenderAccountBalance)
            //{
            //    TransactionHistory.Add(new Transaction(Id, "Transfer", amount, false));
            //    Console.WriteLine("Transfer failed: Insufficient Funds");
            //    return;
            //}
            //SenderAccountBalance -= amount;
            //ReceiverAccountBalance += amount;
            //TransactionHistory.Add(new Transaction(Id, "Transfer", amount, true));
            //Id++;
            //Console.WriteLine("Transfer Successful");
        }

        public void PrintBalance()
        {
            Console.WriteLine($"Current account balance: {SenderAccountBalance}");
        }

        public void GetTransactionHistory()
        {
            if (TransactionHistory.Count == 0)
            {
                Console.WriteLine("No transaction history available");
            }
            foreach (Transaction transaction in TransactionHistory)
            {
                string status = transaction.IsSuccessful ? "successful" : "not successful";
                Console.WriteLine
                    (
                        "{\n" +
                        "\tId: " + transaction.Id + ",\n" +
                        "\tAction: " + transaction.Action + ",\n" +
                        "\tAmount: " + transaction.Amount + ",\n" +
                        "\tDate: " + transaction.dateTime + ",\n" +
                        "\tStatus: " + status + ",\n" +
                        "}"
                    );
            }
        }
    }
}
