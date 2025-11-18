using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loops2
{
    internal class OddNumber
    {
        public static void OddNumber1()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i += 2)
            {
                sum += i;
            }
            Console.WriteLine("Sum of odd numbers: " + sum);

        }
    }
}
