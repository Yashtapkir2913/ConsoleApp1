using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.String
{
    internal class String9
    {
        public static void Palindrome()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            string rev = new string(str.ToCharArray().Reverse().ToArray());

            if (str.Equals(rev, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("String is a palindrome.");
            else
                Console.WriteLine("String is not a palindrome.");
        }
    }
}
