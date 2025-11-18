using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loops2
{
    internal class Sumofdigits
    {
        public static void Sumofdigits1()
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int temp = num;
            while (temp != 0)
            {
                sum += temp % 10;
                temp /= 10;
            }
            Console.WriteLine("Sum of digits: " + sum);

        }
    }
}
