using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.If_Else
{
    public class Prog10
    {
        public static void CaseCheck()
        {
            Console.Write("Enter a character: ");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch >= 'A' && ch <= 'Z')
                Console.WriteLine("Uppercase");
            else if (ch >= 'a' && ch <= 'z')
                Console.WriteLine("Lowercase");
            else
                Console.WriteLine("Not an alphabet");
        }
    }
}
