using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Inheritance
{
    public class Exercise1
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public Exercise1(string make, string model)
        {
            Make = make;
            Model = model;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}");
        }
    }

    // Derived class
    public class Car1 : Exercise1
    {
        public int NumberOfDoors { get; set; }

        public Car1(string make, string model, int numberOfDoors)
            : base(make, model) // calling base class constructor
        {
            NumberOfDoors = numberOfDoors;
        }

        // Override base class method
        public override void DisplayInfo()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}, Number of Doors: {NumberOfDoors}");
        }
    }

    class Vehicle1
    {
        public static void E1()
        {
            Exercise1 v1 = new Exercise1("Toyota", "Corolla");
            v1.DisplayInfo();

            Car1 c1 = new Car1("Ford", "Mustang", 2);
            c1.DisplayInfo();
        }
    }
}
