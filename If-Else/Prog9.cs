using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.If_Else
{
    public class Prog9
    {
        public static void Chartype()
        {
            Console.Write("Enter a character: ");
            char ch = Convert.ToChar(Console.ReadLine());

            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
                Console.WriteLine("Alphabet");
            else if (ch >= '0' && ch <= '9')
                Console.WriteLine("Digit");
            else
                Console.WriteLine("Special Character");
        }
    }
}
