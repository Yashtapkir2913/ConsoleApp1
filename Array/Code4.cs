using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    internal class Code4
    {
        public static void MinMaxElements()
        {
            int[] arr = { 5, 10, 15, 20, 25 };
            int min = arr[0];
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
                if (arr[i] > max)
                    max = arr[i];
            }
            Console.WriteLine("Minimum element: " + min);
            Console.WriteLine("Maximum element: " + max);
        }
    }
}
