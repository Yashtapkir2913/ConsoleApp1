using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loops
{
    public class ReverseNaturalNumbers
    {
        public static void ReverseNaturalNumbers1()
        {
            Console.Write("Enter the value of n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            while (n >= 1)
            {
                Console.Write(n + " ");
                n--;
            }
        }
    }
}
