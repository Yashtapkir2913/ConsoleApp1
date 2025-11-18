using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Ternary_Operator
{
    public class MaxTwoTernary
    {
        public static void MaxTwoTernary1()
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int max = (a > b) ? a : b;
            Console.WriteLine("Maximum = " + max);
        }
    }
}
