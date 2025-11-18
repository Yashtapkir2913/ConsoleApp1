using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Basics
{
    internal class ThirdAngleOfTriangle
    {
        public static void Tt()
        {
            Console.WriteLine("\n--- Third Angle of Triangle ---");
            Console.Write("Enter first angle: ");
            double angle1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second angle: ");
            double angle2 = Convert.ToDouble(Console.ReadLine());
            double angle3 = 180 - (angle1 + angle2);
            Console.WriteLine("Third angle = " + angle3);
        }
    }
}
