using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Polymorphism
{
    public class Mathelper
    {
        public static string Add(string a, int b)
        { return a + b; }
        public static long Add(int a, long b)
        { return a + b; }
        public static float Add(float a, long b)
        { return a + b; }
        public static decimal Add(decimal a, long b)
        { return a + b; }
        public static string Add(string a, long b)
        { return a + b; }
        public static float Add(long a, float b)
        { return a + b; }
        //public static decimal Add(decimal a, float b)
        ////{ return a + b; }
        public static string Add(string a, float b)
        { return a + b; }
        public static decimal Add(int a, decimal b)
        { return a + b; }
        public static decimal Add(long a, decimal b)
        { return a + b; }
        //public static decimal Add(float a, decimal b)
        //{ return a + b; }
        public static string Add(string a, decimal b)
        { return a + b; }
        public static string Add(int a, string b)
        { return a + b; }
        public static string Add(long a, string b)
        { return a + b; }
        public static string Add(float a, string b)
        { return a + b; }
        public static string Add(decimal a, string b)
        { return a + b; }




        public class PolymorphismExample
        {
            public static void P1()
            {

                Console.WriteLine(Mathelper.Add(5, 5));

            }
        }
    }
}
