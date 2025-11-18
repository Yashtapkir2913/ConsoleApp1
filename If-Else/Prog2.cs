using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.If_Else
{
    public class Prog2
    {
        public static void Maxthree()
        {
            Console.Write("Enter three numbers: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
                Console.WriteLine("Maximum = " + a);
            else if (b > c)
                Console.WriteLine("Maximum = " + b);
            else
                Console.WriteLine("Maximum = " + c);

        }
    }
}
