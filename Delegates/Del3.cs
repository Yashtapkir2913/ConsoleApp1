using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Delegates
{
    public delegate double MathOp(double a, double b);

    class Del3
    {
        static double Add(double a, double b) => a + b;
        static double Sub(double a, double b) => a - b;
        static double Mul(double a, double b) => a * b;
        static double Div(double a, double b) => b == 0 ? 0 : a / b;

        public static void M3()
        {
            MathOp op = Mul;
            Console.WriteLine(op(5, 3));
        }
    }
}
