using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loops2
{
    internal class Lastdigit
    {
        public static void Lastdigit1()
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            int last = num % 10;
            int first = num;
            while (first >= 10)
                first /= 10;
            Console.WriteLine("First digit: " + first);
            Console.WriteLine("Last digit: " + last);

        }
    }
}
