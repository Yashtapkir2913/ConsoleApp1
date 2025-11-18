using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Switch_Case
{
    public class TriangleAngles
    {
        public static void TriangleAngles1()
        {
            Console.Write("Enter three angles: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a + b + c == 180 && a > 0 && b > 0 && c > 0)
                Console.WriteLine("Valid triangle");
            else
                Console.WriteLine("Invalid triangle");
        }
    }
}
