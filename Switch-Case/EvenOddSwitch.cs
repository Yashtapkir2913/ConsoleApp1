using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Switch_Case
{
    public class EvenOddSwitch
    {
        public static void EvenOddSwitch1()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            switch (n % 2)
            {
                case 0:
                    Console.WriteLine("Even");
                    break;
                case 1:
                    Console.WriteLine("Odd");
                    break;
            }
        }
    }
}
