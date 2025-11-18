using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Basics
{
    internal class AreaOfEquilateralTriangle
    {
       public static void Ae()
        {
            Console.WriteLine("\n--- Area of Equilateral Triangle ---");
            Console.Write("Enter side: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double area = Math.Sqrt(3) / 4 * a * a;
            Console.WriteLine("Area = " + area);
        }
    }
}
