using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Pattern
{
    internal class Progg6
    {
        public static void HollowPyramid()
        {
            int max = 10;
            for (var i = 1; i <= max; i++)
            {
                for (var j = 1; j <= i; j++)
                {
                    if (j == 1 || j == i || i == max)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
