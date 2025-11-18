using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Switch_Case
{
    public class MaxTwoSwitch
    {
        public static void MaxTwoSwitch1()
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int result = a.CompareTo(b);

            switch (result)
            {
                case 1:
                    Console.WriteLine("Maximum = " + a);
                    break;
                case -1:
                    Console.WriteLine("Maximum = " + b);
                    break;
                case 0:
                    Console.WriteLine("Both numbers are equal");
                    break;
            }
        }
    }
}
