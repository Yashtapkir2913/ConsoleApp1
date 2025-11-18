using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.String
{
    internal class String6
    {
        public static void Count()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            int alphabets = 0, digits = 0, special = 0;

            foreach (char ch in str)
            {
                if (char.IsLetter(ch))
                    alphabets++;
                else if (char.IsDigit(ch))
                    digits++;
                else
                    special++;
            }

            Console.WriteLine("Alphabets: " + alphabets);
            Console.WriteLine("Digits: " + digits);
            Console.WriteLine("Special characters: " + special);
        }
    }
}
