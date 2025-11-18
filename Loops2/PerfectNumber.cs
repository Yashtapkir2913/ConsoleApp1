using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loops2
{
    internal class PerfectNumber
    {
        public static void PerfectNumber1()
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                    sum += i;
            }
            Console.WriteLine(sum == num ? "Perfect number" : "Not perfect");
        }
    }
}
