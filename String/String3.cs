using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.String
{
    internal class String3
    {
        public static void Compare()
        {
            Console.Write("Enter first string: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter second string: ");
            string str2 = Console.ReadLine();

            if (str1 == str2)
                Console.WriteLine("Strings are equal.");
            else
                Console.WriteLine("Strings are not equal.");
        }
    }
}
