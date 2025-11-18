using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Inheritance
{

    public class Appliance
    {
        public string Brand { get; set; }

        public Appliance(string brand)
        {
            Brand = brand;
        }
    }

    public class WashingMachine : Appliance
    {
        public int Capacity { get; set; }  

        public WashingMachine(string brand, int capacity) : base(brand)
        {
            Capacity = capacity;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Brand: {Brand}, Capacity: {Capacity} kg");
        }
    }

    class Appliance1
    {
        public static void M1()
        {
            WashingMachine wm = new WashingMachine("Samsung", 7);
            wm.ShowDetails();
        }
    }

}// Appliance1.M1();
