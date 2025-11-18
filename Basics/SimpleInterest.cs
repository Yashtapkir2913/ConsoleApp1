using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Basics
{
    internal class SimpleInterest
    {
        public static void Si()
        {
            Console.WriteLine("\n--- Simple Interest ---");
            Console.Write("Enter Principal (P): ");
            double P = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Time (T in years): ");
            double T = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Rate (R in %): ");
            double R = Convert.ToDouble(Console.ReadLine());
            double SI = P * T * R / 100;
            Console.WriteLine("Simple Interest = " + SI);
        }
    }
}
