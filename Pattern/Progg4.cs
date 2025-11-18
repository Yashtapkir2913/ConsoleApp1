using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Pattern
{
    internal class Progg4
    {
        public static void Parellogram()
        {
           
                int size = 8;
                for (int row = 1; row <= size; ++row)
                {
                    for (int col = 1; col <= row; ++col)
                    {
                        Console.Write(" ");
                    }

                    for (int col = 1; col <= size; ++col)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }
                Console.ReadLine();
           
        }
    }
}
