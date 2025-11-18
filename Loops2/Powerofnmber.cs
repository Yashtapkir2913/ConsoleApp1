using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loops2
{
    internal class Powerofnmber
    {
        public static void Powerofnmber1()
        {
            Console.Write("Enter base: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter exponent: ");
            int e = int.Parse(Console.ReadLine());
            int result = 1;
            for (int i = 1; i <= e; i++)
                result *= b;
            Console.WriteLine("Power: " + result);
        }
    }
}
