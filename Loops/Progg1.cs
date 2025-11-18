using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loops
{
    public class Progg1
    {
        public static void Natural()
        {
            Console.Write("Enter the value of n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            while (i <= n)
            {
                Console.Write(i + " ");
                i++;
            }
        }
    }
}
