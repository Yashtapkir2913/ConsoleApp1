using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Basics
{
 class PerimeterOfRectangle
    {
        public static void P()
        {
            Console.WriteLine("\n--- Perimeter of Rectangle ---");
            Console.Write("Enter length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter breadth: ");
            double breadth = Convert.ToDouble(Console.ReadLine());
            double perimeter = 2 * (length + breadth);
            Console.WriteLine("Perimeter = " + perimeter);
        }
    }
}
