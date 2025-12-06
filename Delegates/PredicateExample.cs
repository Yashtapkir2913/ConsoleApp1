using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Delegates
{
    internal class PredicateExample
    {
        public static void M1()
        {
            Predicate<int> isPositive = x => x > 0;
            Predicate<int> isOdd = x => x % 2 != 0;
            Predicate<string> isEmpty = s => string.IsNullOrEmpty(s);
            Predicate<string> isLong = s => s.Length > 5;
            Predicate<int> isAdult = age => age >= 18;
            Predicate<double> isWhole = x => x % 1 == 0;
            Predicate<char> isVowel = c => "aeiouAEIOU".Contains(c);
            Predicate<List<int>> hasElements = list => list.Count > 0;
            Predicate<string> startsWithA = s => s.StartsWith("S");
            Predicate<int> isMultipleOf10 = x => x % 10 == 0;

            Console.WriteLine(isPositive(10));
            Console.WriteLine(isOdd(9));
            Console.WriteLine(isEmpty(""));
            Console.WriteLine(isLong("Welcome"));
            Console.WriteLine(isAdult(20));
            Console.WriteLine(isWhole(12.0));
            Console.WriteLine(isVowel('E'));
            Console.WriteLine(hasElements(new List<int> { 1, 2 }));
            Console.WriteLine(startsWithA("Apple"));
            Console.WriteLine(isMultipleOf10(40));
        }
    }
}
