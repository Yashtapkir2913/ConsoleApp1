using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.String
{
    internal class String4
    {
        public static void Convert_l_to_u()
        {
            Console.Write("Enter a string in lowercase: ");
            string str = Console.ReadLine();

            string upper = str.ToUpper();
            Console.WriteLine("Uppercase string: " + upper);
        }
    }
}
