using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Delegates
{
    class Del5
    {
        public static void M5()
        {
            Func<int, int, int> multiply = (a, b) => a * b;
            Console.WriteLine(multiply(6, 7));
        }
    }
}
