using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loops2
{
    internal class PrimeNumber
    {
        public static void PrimeNumber1()
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (num < 2) isPrime = false;
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine(isPrime ? "Prime" : "Not prime");
        }
    }
}
