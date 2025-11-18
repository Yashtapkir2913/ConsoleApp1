using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Array
{
    internal class Code7
    {
        public static void SearchspecificElement()
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            Console.Write("Enter element to search: ");
            int search = Convert.ToInt32(Console.ReadLine());
            bool found = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == search)
                {
                    Console.WriteLine("Element found at index: " + i);
                    found = true;
                    break;
                }
            }

            if (!found)
                Console.WriteLine("Element not found in array.");
        }
    }
}
