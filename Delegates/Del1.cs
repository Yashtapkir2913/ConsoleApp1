using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Delegates
{
    public delegate int Difference(int a, int b);

    class Del1
    {
        static int Subtract(int x, int y) => x - y;

        public static void M1()
        {
            Difference d = Subtract;
            Console.WriteLine(d(10, 3));
        }
    }

}
