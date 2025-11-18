using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Constructor
{
    using System;

        public class Car
        {
            public string model { get; set; }
            public string color { get; set; }
            public int speed { get; set; }

            public Car()
            {
                model = "Swift";
                color = "Red";
                speed = 0;
            }

            public Car(string model, string color, int speed)
            {
                this.model = model;
                this.color = color;
                this.speed = speed;
            }

            public void Accelerate(int value)
            {
                speed += value;
                Console.WriteLine($"{model} accelerated. Current speed: {speed} km/h");
            }

            public void Brake()
            {
                speed = 0;
                Console.WriteLine($"{model} has stopped.");
            }

            public override string ToString()
            {
                return $"Car [Model: {model}, Color: {color}, Speed: {speed}]";
            }
        }

        public class CarTest
        {
            public static void C1()
            {
                Car c1 = new Car();
                Console.WriteLine(c1);
                c1.Accelerate(60);
                c1.Brake();

                Console.WriteLine("-------------------------");

                Car c2 = new Car("BMW", "Black", 120);
                Console.WriteLine(c2);
                c2.Brake();
            }
        }
}

//CarTest.C1();
