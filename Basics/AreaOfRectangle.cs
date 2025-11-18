using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Basics
{
    class AreaOfRectangle()
    {
        public static void Ar()
        {
            Console.WriteLine("\n--- Area of Rectangle ---");
            Console.Write("Enter length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter breadth: ");
            double breadth = Convert.ToDouble(Console.ReadLine());
            double area = length * breadth;
            Console.WriteLine("Area = " + area);
        }
    }
}