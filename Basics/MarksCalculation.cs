using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Basics
{
    internal class MarksCalculation
    {
        public static void Mc()
        {
            Console.WriteLine("\n--- Marks Calculation ---");
            double total = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Enter marks for subject " + i + ": ");
                total += Convert.ToDouble(Console.ReadLine());
            }
            double average = total / 5;
            double percentage = total / 500 * 100;
            Console.WriteLine("Total = " + total);
            Console.WriteLine("Average = " + average);
            Console.WriteLine("Percentage = " + percentage + "%");
        }
    }
}
