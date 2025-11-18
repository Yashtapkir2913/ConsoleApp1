using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loops2
{
    internal class Palindrome
    {
        public static void Palindrome1()
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            int original = num;
            int reverse = 0;
            while (num != 0)
            {
                reverse = reverse * 10 + num % 10;
                num /= 10;
            }
            if (original == reverse)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not a palindrome");
        }
    }
}
