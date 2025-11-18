using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.If_Else
{
    public class Prog6
    {
        public static void Leapyear()
        {
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                Console.WriteLine("Leap Year");
            else
                Console.WriteLine("Not a Leap Year");
        }
    }
}
