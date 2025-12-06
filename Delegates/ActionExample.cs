using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Delegates
{
    internal class ActionExample
    {
        public static void M1()
        {
            Action sayHello = () => Console.WriteLine("Hello");
            Action<string> print = msg => Console.WriteLine(msg);
            Action<int> showSquare = x => Console.WriteLine(x * x);
            Action<string, int> userInfo = (name, age) =>
                Console.WriteLine($"{name} - {age}");
            Action<int> printNum = n => Console.WriteLine(n);
            Action clearConsole = () => Console.Clear();
            Action<bool> showFlag = f => Console.WriteLine(f);
            Action<DateTime> showDate = d => Console.WriteLine(d);
            Action<string> error = e => Console.WriteLine("Error: " + e);
            Action<double> showDouble = d => Console.WriteLine(d);

            sayHello();
            print("Welcome Yash");
            showSquare(6);
            userInfo("Yash", 23);
            printNum(10);
            showFlag(true);
            showDate(DateTime.Now);
            error("Invalid input");
            showDouble(12.55);
        }
    }
}
