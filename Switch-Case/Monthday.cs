using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Switch_Case
{
    public class Monthday
    {
        public static void Monthday1()
        {
            Console.Write("Enter month number (1-12): ");
            int month = Convert.ToInt32(Console.ReadLine());

            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                Console.WriteLine("31 days");
            else if (month == 4 || month == 6 || month == 9 || month == 11)
                Console.WriteLine("30 days");
            else if (month == 2)
                Console.WriteLine("28 or 29 days");
            else
                Console.WriteLine("Invalid month number");
        }
    }
}
