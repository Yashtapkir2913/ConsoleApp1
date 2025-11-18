using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.String
{
    internal class String2
    {
        public static void Concatenate()
        {
            Console.Write("Enter first string: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter second string: ");
            string str2 = Console.ReadLine();

            string result = str1 + str2;
            Console.WriteLine("Concatenated string: " + result);
        }
    }
}
