using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Ternary_Operator
{
    public class AlphabetCheckTernary
    {
        public static void AlphabetCheckTernary1()
        {
            Console.Write("Enter a character: ");
            char ch = Convert.ToChar(Console.ReadLine());

            string result = ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
                            ? "Alphabet"
                            : "Not an Alphabet";

            Console.WriteLine(result);
        }
    }
}
