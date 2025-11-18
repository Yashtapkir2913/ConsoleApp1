using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Pattern
{
    internal class Progg3
    {
        public static void Rightangle()
        {
            
                int val = 8;
                int i, j, k;
                for (i = 1; i <= val; i++)
                {
                    for (j = 1; j <= val - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (k = 1; k <= i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
                Console.ReadLine();
            

        }
    }
}
