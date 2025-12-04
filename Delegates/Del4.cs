using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Delegates
{
    public delegate string StringOp(string s);

    class Del4
    {
        static string Upper(string s) => s.ToUpper();
        static string Lower(string s) => s.ToLower();
        static string Reverse(string s) => new string(s.Reverse().ToArray());

        public static void M4()
        {
            StringOp op = Reverse;
            Console.WriteLine(op("Hello World"));
        }
    }
}
