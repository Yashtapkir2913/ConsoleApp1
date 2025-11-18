using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Switch_Case
{
    public class VowelConsonantSwitch
    {
        public static void VowelConsonantSwitch1()
        {
            Console.Write("Enter an alphabet: ");
            char ch = Char.ToLower(Convert.ToChar(Console.ReadLine()));

            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Consonant");
                    break;
            }
        }
    }
}
