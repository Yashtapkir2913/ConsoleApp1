using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Delegates
{
    class DelegateExample
    {
        public static void DelClass()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            Predicate<int> isEven = n => n % 2 == 0;

            Action<int> print = n => Console.WriteLine($"{n}");

            Console.WriteLine("Numbers in List are: ");
            foreach ( int n in numbers ) print( n );

            Console.WriteLine("Even numbers are:  ");
            foreach (var num in numbers)
            {
                if (isEven(num))
                    print(num);
            }
        }
    }
    public class MyDelClass
    {
        public static void M1()
        {
            DelegateExample.DelClass();
        }
    }


}


