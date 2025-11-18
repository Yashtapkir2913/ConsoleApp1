using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loops2
{
    internal class Numberofdigits
    {
        public static void Numberofdigits1()
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            int temp = num;
            while (temp != 0)
            {
                temp /= 10;
                count++;
            }
            Console.WriteLine("Number of digits: " + count);

        }
    }
}
