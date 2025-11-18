using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface
{
    public interface IPayment
    {
        void ProcessPayment();
    }

    public class CreditCardPayment : IPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing credit card payment...");
        }
    }

    public class PayPalPayment : IPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing PayPal payment...");
        }
    }

    
    class IPayment1
    {
        public static void M1()
        {
            IPayment creditCard = new CreditCardPayment();
            creditCard.ProcessPayment();

            IPayment paypal = new PayPalPayment();
            paypal.ProcessPayment();
        }
    }
}//IPayment1.M1();
