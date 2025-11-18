using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Ternary_Operator
{
    public class EvenOddTernary
    {
        public static void EvenOddTernary1()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            string result = (n % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine(result);
        }
    }
}
