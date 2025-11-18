using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Basics
{
    internal class CircleCalculations
    {
        public static void Cc()
        {
            Console.WriteLine("\n--- Circle Calculations ---");
            Console.Write("Enter radius: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double diameter = 2 * r;
            double circumference = 2 * Math.PI * r;
            double area = Math.PI * r * r;
            Console.WriteLine("Diameter = " + diameter);
            Console.WriteLine("Circumference = " + circumference);
            Console.WriteLine("Area = " + area);
        }
    }
}
