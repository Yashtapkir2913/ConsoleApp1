using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    internal class Code1
    {
        public static void PrintArray()
        {
            int[] arr = { 10, 20, 30, 40, 50 };

            Console.WriteLine("Array Elements:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
