using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Basics
{
    internal class LengthConversion
    {
        public static void Lc()
        {
            Console.WriteLine("\n--- Length Conversion ---");
            Console.Write("Enter length in centimeters: ");
            double cm = Convert.ToDouble(Console.ReadLine());
            double meters = cm / 100;
            double kilometers = cm / 100000;
            Console.WriteLine("Meters = " + meters);
            Console.WriteLine("Kilometers = " + kilometers);
        }
    }
}
