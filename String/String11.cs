using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.String
{
    internal class String11
    {
        public static void Last_occurance()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            Console.Write("Enter a character to find: ");
            char ch = Console.ReadLine()[0];

            int index = str.LastIndexOf(ch);

            if (index != -1)
                Console.WriteLine($"Last occurrence of '{ch}' is at position {index}");
            else
                Console.WriteLine("Character not found.");
        }
    }
}
