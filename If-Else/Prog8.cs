using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.If_Else
{
    public class Prog8
    {
        public static void Vowel()
        {
            Console.Write("Enter an alphabet: ");
            char ch = Char.ToLower(Convert.ToChar(Console.ReadLine()));

            if ("aeiou".Contains(ch))
                Console.WriteLine("Vowel");
            else
                Console.WriteLine("Consonant");
        }
    }
}
