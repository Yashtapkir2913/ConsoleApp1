using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loops
{
    public class SumEvenNumbers
    {
        public static void SumEvenNumbers1()
        {
            Console.Write("Enter the value of n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int i = 2, sum = 0;
            while (i <= n)
            {
                sum += i;
                i += 2;
            }
            Console.WriteLine("Sum of even numbers = " + sum);
        }
    }
}
