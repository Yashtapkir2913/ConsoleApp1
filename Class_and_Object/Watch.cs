using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Class
{
    public class Watch
    {
        public string brand;
        public string color;

        public double price;


        public void DisplayWatch()
        {
            Console.WriteLine($"Brand: {brand}, Color: {color}, Price: ₹{price}");
        }
    }

}
//Watch W1 = new Watch();
//W1.brand = "Fossil";
//W1.color = "Black";
//W1.price = 9999.99;
