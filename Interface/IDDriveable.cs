using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface
{

    public interface IDriveable
    {
        void Start();
        void Forward();
        void Turn(double angle);
        void Stop();
    }

    public class Bicycle : IDriveable
    {
        public void Start()
        {
            Console.WriteLine("Bicycle started.");
        }

        public void Forward()
        {
            Console.WriteLine("Bicycle moving forward.");
        }

        public void Turn(double angle)
        {
            Console.WriteLine($"Bicycle turning by {angle} degrees.");
        }

        public void Stop()
        {
            Console.WriteLine("Bicycle stopped.");
        }

        public override string ToString()
        {
            return "This is a Bicycle.";
        }
    }


    public class Car1 : IDriveable
    {
        public void Start()
        {
            Console.WriteLine("Car engine started.");
        }

        public void Forward()
        {
            Console.WriteLine("Car moving forward.");
        }

        public void Turn(double angle)
        {
            Console.WriteLine($"Car turning by {angle} degrees.");
        }

        public void Stop()
        {
            Console.WriteLine("Car stopped.");
        }

        public override string ToString()
        {
            return "This is a Car.";
        }
    }


    class IDriveable1
    {
        public static void M1()
        {
            // Bicycle object
            IDriveable bicycle = new Bicycle();
            bicycle.Start();
            bicycle.Forward();
            bicycle.Turn(45);
            bicycle.Stop();
            Console.WriteLine(bicycle.ToString());
            Console.WriteLine("---------------------");

            // Car object
            IDriveable car = new Car1();
            car.Start();
            car.Forward();
            car.Turn(45);
            car.Stop();
            Console.WriteLine(car.ToString());
            Console.WriteLine("---------------------");
        }
    }

}//IDriveable1.M1();

