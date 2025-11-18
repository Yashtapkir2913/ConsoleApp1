using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Ternary_Operator
{
    public class LeapYearTernary
    {
        public static void LeapYearTernary1()
        {
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            string result = ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                            ? "Leap Year"
                            : "Not a Leap Year";

            Console.WriteLine(result);
        }
    }
}
