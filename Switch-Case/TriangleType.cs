using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Switch_Case
{
    public class TriangleType
    {
        public static void TriangleType1()
        {
            Console.Write("Enter three sides: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a == b && b == c)
                Console.WriteLine("Equilateral Triangle");
            else if (a == b || b == c || a == c)
                Console.WriteLine("Isosceles Triangle");
            else
                Console.WriteLine("Scalene Triangle");
        }
    }
}
