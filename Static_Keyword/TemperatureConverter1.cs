using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Static_Keyword
{
    public static class TemperatureConverter1
    {
        public static double CelsiusToFahrenheit(double celsius)
        {
            return celsius * 9 / 5 + 32;
        }
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
        class Test1
        {
            public static void S1()
            {
                Console.WriteLine(TemperatureConverter1.CelsiusToFahrenheit(74));
                Console.WriteLine(TemperatureConverter1.FahrenheitToCelsius(23));

            }
        }

    }
//Test1.S1();