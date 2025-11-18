using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loops2
{
    internal class ASCII
    {
        public static void ASCII1()
        {
            for (int i = 0; i <= 255; i++)
            {
                Console.WriteLine($"{i} = {(char)i}");
            }
        }
    }
}
