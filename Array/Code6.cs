using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    internal class Code6
    {
        public static void ReverseArray()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int n = arr.Length;

            Console.WriteLine("Original Array:");
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine("\nReversed Array:");
            for (int i = n - 1; i >= 0; i--)
                Console.Write(arr[i] + " ");
        }
    }
}
