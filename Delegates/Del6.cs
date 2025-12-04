using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Delegates
{
    class Del6
    {
        public static void M6()
        {
            Func<string, int> length = s => s.Length;
            Console.WriteLine(length("Hello"));
        }
    }
}
