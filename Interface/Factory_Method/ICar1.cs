using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface.Factory_Method
{
    interface ICar1
    {
        void Drive();
    }

    class Thar : ICar1
    {
        public void Drive() => Console.WriteLine("Driving Thar");
    }

    class BMW : ICar1
    {
        public void Drive() => Console.WriteLine("Driving BMW");
    }

    static class CarFactory
    {
        public static ICar1 GetCar(string type)
        {
            if (type == "Thar")
            {
                return new Thar();
            }
            else if (type == "BMW")
            {
                return new BMW();
            }
            else
            {
                throw new Exception("Invalid Car Type");
            }
        }
    }
    public class FactoryMethodPattern1
    {
        public static void M1()
        {
            ICar1 car = CarFactory.GetCar("BMW");
            car.Drive();
        }
    }
}//FactoryMethodPattern1.M1();
