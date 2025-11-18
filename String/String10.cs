using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.String
{
    internal class String10
    {
        public static void First_occurance()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            Console.Write("Enter a character to find: ");
            char ch = Console.ReadLine()[0];

            int index = str.IndexOf(ch);

            if (index != -1)
                Console.WriteLine($"First occurrence of '{ch}' is at position {index}");
            else
                Console.WriteLine("Character not found.");
        }
    }
}
