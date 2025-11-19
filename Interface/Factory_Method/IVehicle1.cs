using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface.Factory_Method
{
    
        public interface IVehicle1
        {
            void Start();
            void Stop();
        }

        public class Car2 : IVehicle1
        {
            public void Start() => Console.WriteLine("Car started.");
            public void Stop() => Console.WriteLine("Car stopped.");
        }

        public class Bike2 : IVehicle1
        {
            public void Start() => Console.WriteLine("Bike started.");
            public void Stop() => Console.WriteLine("Bike stopped.");
        }

    public static class VehicleFactory
    {
        public static IVehicle1 CreateVehicle(string type)
        {
            if (type == "car") return new Car2();
            if (type == "bike") return new Bike2();
            throw new Exception("Invalid type");
        }
    }


    class IVehicle2
        {
            public static void M1()
            {
                IVehicle1 car = VehicleFactory.CreateVehicle("car");
                car.Start();
                car.Stop();

                IVehicle1 bike = VehicleFactory.CreateVehicle("bike");
                bike.Start();
                bike.Stop();
            }
        }


}//IVehicle1.M1();




