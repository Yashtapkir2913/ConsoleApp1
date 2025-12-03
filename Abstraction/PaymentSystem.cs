using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//abstract class program
namespace ConsoleApp1.Abstraction
{
        public abstract class Payment
        {
            public abstract void MakePayment(double amount);

            public void GeneratePayment()
            {
                Random rand = new Random();
                int transactionId = rand.Next(10000, 99999); 
                Console.WriteLine($"Transaction ID: {transactionId}");
            }
        }

        public class CreditCardPayment : Payment
        {
            public override void MakePayment(double amount)
            {
                Console.WriteLine($"Credit Card payment of {amount} processed successfully.");
                GeneratePayment(); 
            }
        }

        public class UpiPayment : Payment
        {
            public override void MakePayment(double amount)
            {
                Console.WriteLine($"UPI payment of {amount} processed successfully.");
                GeneratePayment(); 
            }
        }

        class PaymentSystem1
        {
            public static void M1()
            {
                Payment payment1 = new CreditCardPayment();
                payment1.MakePayment(2500.75);

                Console.WriteLine();

                Payment payment2 = new UpiPayment();
                payment2.MakePayment(1200.50);
            }
        }
}
