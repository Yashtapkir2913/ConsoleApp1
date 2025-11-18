using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Static_Keyword
{

    class BankAccount
    {
        public static string bankName = "Bank";
        public double balance;

       
        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }

        
        public static void ChangeBankName(string newName)
        {
            bankName = newName;
        }

        
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited {amount}. New balance: {balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        
        public void Display()
        {
            Console.WriteLine("Bank Name: " + bankName);
            Console.WriteLine("Account Balance: " + balance);
        }
    }

    class BankProgram1
    {
        public static void M1()
        {
            BankAccount account1 = new BankAccount(1000);

           
            account1.Deposit(600);
            BankAccount.ChangeBankName("SBI Bank");
            account1.Display();
        }
    }

}
//BankProgram1.M1();
