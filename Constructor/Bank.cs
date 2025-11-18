using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Constructor
{
    public class Bank
    {
        public int id { get; set; }
        public string bankname { get; set; }
        public string balance { get; set; }
        
        public Bank()
        {
            this.id = 0;
            this.bankname = "SBI Bank";
            this.balance = "1000";
        }

        public Bank(int id, string bankname, string balance)
        {
            this.id = id;
            this.bankname = bankname;
            this.balance = balance;
        }

        public override string ToString()
        {
            return $"Bank [ID: {id}, Name: {bankname}, Balance: {balance}]";
        }

        public  void deposit(decimal amount)
        {
            balance = balance + amount;

        }
        public void withdraw(decimal amount)
        {
            decimal currentBalance = decimal.Parse(balance);
            if (amount > currentBalance)
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
            }
            else
            {
                currentBalance -= amount;
                balance = currentBalance.ToString();
                Console.WriteLine($"Withdrew: {amount}. New Balance: {balance}");
            }
        }
    }
    public class Bank11
    {
        public static void B1()
        {

            Bank b1 = new Bank();
            Console.WriteLine(b1);

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");

            Bank b2 = new Bank(101, "HDFC Bank", "5000");
            b2.deposit(2000);
            b2.withdraw(1000);
            Console.WriteLine(b2);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");

            Console.WriteLine("ID is: {0}", b2.id);

        }
    }
}

// Bank1.B1();
