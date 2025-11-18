using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Switch_Case
{
    public class TriangleSides
    {
        public static void TriangleSides1()
        {
            Console.Write("Enter three sides: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
                Console.WriteLine("Valid triangle");
            else
                Console.WriteLine("Invalid triangle");
        }
    }
}
