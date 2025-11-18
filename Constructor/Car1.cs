using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Constructor
{
    using System;

    namespace ConsoleApp1.StaticExample
    {
        public class Car1
        {
            public string model;           // instance variable
            public string color;           // instance variable
            public static int totalCars;   // static variable (shared among all cars)

            // Constructor
            public Car1(string m, string c)
            {
                model = m;
                color = c;
                totalCars++;               // increases when a new car is created
            }

            // Instance method
            public void Display()
            {
                Console.WriteLine($"Car Model: {model}, Color: {color}");
            }

            // Static method
            public static void ShowTotalCars()
            {
                Console.WriteLine("Total Cars Created: " + totalCars);
            }
        }

        public class CarTest1
        {
            public static void C1()
            {
                Car1 c1 = new Car1("Maruti Swift", "Red");
                Car1 c2 = new Car1("Hyundai i20", "Blue");
                Car1 c3 = new Car1("Tata Nexon", "White");

                Console.WriteLine("--------------------------");
                c1.Display();
                c2.Display();
                c3.Display();

                Console.WriteLine("--------------------------");
                // Accessing static method using class name
                Car1.ShowTotalCars();
            }
        }
    }

}
//CarTest1.C1();
