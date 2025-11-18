using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Basics
{
    internal class AreaOfTriangle
    {
        public static void At()
        {
            Console.WriteLine("\n--- Area of Triangle ---");
            Console.Write("Enter base: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height: ");
            double h = Convert.ToDouble(Console.ReadLine());
            double area = 0.5 * b * h;
            Console.WriteLine("Area = " + area);
        }
    }
}
