using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loops2
{
    internal class Fibonacci
    {
        public static void Fibonacci1()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int a = 0, b = 1;
            Console.Write(a + " " + b + " ");
            for (int i = 3; i <= n; i++)
            {
                int c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
        }
    }
}
