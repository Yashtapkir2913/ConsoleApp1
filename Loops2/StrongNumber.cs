using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loops2
{
    internal class StrongNumber
    {
        public static void StrongNumber1()
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int sum = 0;
            while (temp != 0)
            {
                int digit = temp % 10;
                int fact = 1;
                for (int i = 1; i <= digit; i++)
                    fact *= i;
                sum += fact;
                temp /= 10;
            }
            Console.WriteLine(sum == num ? "Strong number" : "Not strong");
        }
    }
}
