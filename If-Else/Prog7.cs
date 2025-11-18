using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.If_Else
{
    public class Prog7
    {
        public static void CharAlpha()
        {
            Console.Write("Enter a character: ");
            char ch = Convert.ToChar(Console.ReadLine());

            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
                Console.WriteLine("Alphabet");
            else
                Console.WriteLine("Not an alphabet");
        }
    }
}
