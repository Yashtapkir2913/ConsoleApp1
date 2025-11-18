using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.If_Else
{
    public class Prog3
    {
        public static void Checknumber()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n > 0)
                Console.WriteLine("Positive");
            else if (n < 0)
                Console.WriteLine("Negative");
            else
                Console.WriteLine("Zero");
        }
    }
}
