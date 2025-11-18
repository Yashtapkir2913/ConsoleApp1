using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loops2
{
    internal class Productofdigits
    {
        public static void Productofdigits1()
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            int product = 1;
            int temp = num;
            while (temp != 0)
            {
                product *= temp % 10;
                temp /= 10;
            }
            Console.WriteLine("Product of digits: " + product);

        }
    }
}
