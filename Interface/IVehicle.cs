using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface
{
    public interface IVehicle
    {
        void Start();
        void Stop();
    }

    public class Car : IVehicle
    {
        public void Start() => Console.WriteLine("Car started.");
        public void Stop() => Console.WriteLine("Car stopped.");
    }

    public class Bike : IVehicle
    {
        public void Start() => Console.WriteLine("Bike started.");
        public void Stop() => Console.WriteLine("Bike stopped.");
    }

    
    class IVehicle1
    {
        public static void M1()
        {
            IVehicle car = new Car();
            car.Start();
            car.Stop();

            IVehicle bike = new Bike();
            bike.Start();
            bike.Stop();
        }
    }
}//IVehicle1.M1();
