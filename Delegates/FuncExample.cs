using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Delegates
{
    internal class FuncExample
    {
        public static void M1()
        {
            Func<int, int> square = x => x * x;
            Func<int, int, int> add = (a, b) => a + b;
            Func<string> greet = () => "Hello";
            Func<string, int> length = s => s.Length;
            Func<double, double> half = n => n / 2;
            Func<int, bool> isEven = n => n % 2 == 0;
            Func<int, int, int> max = (a, b) => a > b ? a : b;
            Func<string, string> upper = s => s.ToUpper();
            Func<int> randomNum = () => new Random().Next(1, 100);
            Func<DateTime, string> formatDate = d => d.ToShortDateString();

            Console.WriteLine(square(5));
            Console.WriteLine(add(3, 7));
            Console.WriteLine(greet());
            Console.WriteLine(length("Yash"));
            Console.WriteLine(half(20));
            Console.WriteLine(isEven(8));
            Console.WriteLine(max(10, 20));
            Console.WriteLine(upper("hello"));
            Console.WriteLine(randomNum());
            Console.WriteLine(formatDate(DateTime.Now));
        }
    }
}
