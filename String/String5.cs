using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.String
{
    internal class String5
    {
        public static void Convert_u_to_l()
        {
            Console.Write("Enter a string in uppercase: ");
            string str = Console.ReadLine();

            string lower = str.ToLower();
            Console.WriteLine("Lowercase string: " + lower);
        }
    }
}
