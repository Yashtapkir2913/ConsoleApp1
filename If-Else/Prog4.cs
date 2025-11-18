using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.If_Else
{
    internal class Prog4
    {
        public static void Checkdivisibility()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 5 == 0 && n % 11 == 0)
                Console.WriteLine("Divisible by 5 and 11");
            else
                Console.WriteLine("Not divisible by 5 and 11");
        }
    }
}
//Divisible numbers are: 55, 110, 165