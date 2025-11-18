using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.String
{
    internal class String7
    {
        public static void Vowels_Consonants()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine().ToLower();

            int vowels = 0, consonants = 0;

            foreach (char ch in str)
            {
                if (ch >= 'a' && ch <= 'z')
                {
                    if ("aeiou".Contains(ch))
                        vowels++;
                    else
                        consonants++;
                }
            }

            Console.WriteLine("Vowels: " + vowels);
            Console.WriteLine("Consonants: " + consonants);
        }
    }
}
