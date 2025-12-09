using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Collections
{
    internal class SortedDictionary
    {
        private SortedDictionary<int, string> students = new SortedDictionary<int, string>();

        public void Coll()
        {
            students.Add(1, "Shreyas");
            students.Add(2, "Yash");
            students.Add(3, "Aditya");
            Console.WriteLine("All Students:");
            foreach (var s in students)
            {
                Console.WriteLine($"Roll No: {s.Key}, Name: {s.Value}");
            }

            //students.Remove(3);

            //Console.WriteLine("\nAfter removing Roll No 3:");
            //foreach (var s in students)
            //{
            //    Console.WriteLine($"Roll No: {s.Key}, Name: {s.Value}");
            //}
        }
    }
    class StudColl1
    {
        public static void M1()
        {
            SortedDictionary sc = new SortedDictionary();
            sc.Coll();
        }
    }
}
