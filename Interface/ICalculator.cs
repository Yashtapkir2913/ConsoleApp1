using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface
{
    using System;

    public interface ICalculator
    {
        int Add(int a, int b);
        int Sub(int a, int b);
        int Mul(int a, int b);
        double Div(int a, int b);
    }

    public class Calculator : ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }

        public double Div(int a, int b)
        {
            if (b != 0)
            {
                return (double)a / b;
            }
            else
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
        }
    }

    public class ICalculator1
    {
        public static void M1()
        {
            ICalculator calc = new Calculator();

            Console.WriteLine($"Add: {calc.Add(10, 5)}");
            Console.WriteLine($"Sub: {calc.Sub(10, 5)}");
            Console.WriteLine($"Mul: {calc.Mul(10, 5)}");
            Console.WriteLine($"Div: {calc.Div(10, 5)}");

            Console.WriteLine($"Div (7, 2): {calc.Div(7, 2)}");

            try
            {
                Console.WriteLine($"Div (10, 0): {calc.Div(10, 0)}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}//ICalculator1.M1();
