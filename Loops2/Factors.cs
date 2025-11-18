using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loops2
{
    internal class Factors
    {
        public static void Factors1()
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Factors: ");
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    Console.Write(i + " ");
            }
        }
    }
}
