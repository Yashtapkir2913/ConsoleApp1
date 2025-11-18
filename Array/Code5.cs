using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    internal class Code5
    {
        public static void EvenOdd()
        {
            int[] arr = { 2, 5, 8, 11, 14, 17 };
            int even = 0, odd = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    even++;
                else
                    odd++;
            }

            Console.WriteLine("Total Even numbers are: " + even);
            Console.WriteLine("Total Odd numbers are: " + odd);
        }
    }
}
