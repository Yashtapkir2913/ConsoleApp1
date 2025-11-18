using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loops2
{
    internal class Factorial
    {
        public static void Factorial1()
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            long fact = 1;
            for (int i = 1; i <= num; i++)
                fact *= i;
            Console.WriteLine("Factorial: " + fact);
        }
    }
}
