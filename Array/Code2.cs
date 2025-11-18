using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    internal class Code2
    {
        public static void SumOfElements()
        {
            int[] arr = { 5, 10, 15, 20, 25 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Sum of array elements: " + sum);
        }
    }
}
