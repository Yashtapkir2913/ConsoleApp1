using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Pattern
{
    internal class Proggg1
    {
        public static void P1()
        {
            {
                for (int row = 8; row >= 1; --row)
                {
                    for (int col = 1; col <= row; ++col)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }
}
