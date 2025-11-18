using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Ternary_Operator
{
    public class MaxThreeTernary
    {
        public static void MaxThreeTernary1()
        {
            Console.Write("Enter three numbers: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int max = (a > b) ? (a > c ? a : c) : (b > c ? b : c);
            Console.WriteLine("Maximum = " + max);
        }
    }
}
