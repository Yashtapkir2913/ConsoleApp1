using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loops
{
    internal class SumFromGivenRange
    {
        public static void SumFromGivenRange1() 
        {
            Console.Write("Enter start: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter end: ");
            int end = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = start; i <= end; i++)
                sum += i;
            Console.WriteLine("Sum = " + sum);
        }
    }
}
