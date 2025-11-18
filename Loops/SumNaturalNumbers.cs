using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loops
{
    public class SumNaturalNumbers
    {
        public static void SumNaturalNumbers1()
        {
            Console.Write("Enter the value of n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int i = 1, sum = 0;
            while (i <= n)
            {
                sum += i;
                i++;
            }
            Console.WriteLine("Sum = " + sum);
        }
    }
}
