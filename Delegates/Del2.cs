using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Delegates
{
    public delegate int Operation(int a, int b);
    class Del2
    {
        static int Add(int a, int b) => a + b;

        static int Calculate(Operation op, int x, int y)
        {
            return op(x, y);
        }

        public static void M2()
        {
            Console.WriteLine(Calculate(Add, 7, 8));
        }
    }
}
