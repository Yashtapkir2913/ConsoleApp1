using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Pattern
{
    internal class Progg5
    {
        public static void Pyramid()
        {
            int x = 8;
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= (x - i); j++)
                    Console.Write(" ");

                for (int t = 1; t < i * 2; t++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
