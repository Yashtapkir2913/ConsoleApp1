using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Abstraction
{
    abstract class Shape11
    {
        public abstract void Area();

    }
    class Cirle : Shape11
    {
        public int radius = 5;
        public double area;
        public override void Area()
        {
            area= 3.14 * radius * radius;
            Console.WriteLine("Area of Circle: " + Area);
        }
    }
}
