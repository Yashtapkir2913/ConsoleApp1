using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loops2
{
    internal class LCM
    {
        public static void LCM1()
        {
            Console.Write("Enter two numbers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int lcm = (a * b) / GCD(a, b);
            Console.WriteLine("LCM: " + lcm);

            int GCD(int x, int y)
            {
                while (y != 0)
                {
                    int temp = y;
                    y = x % y;
                    x = temp;
                }
                return x;
            }
        }
    }
}
