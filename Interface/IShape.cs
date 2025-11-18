using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface
{
    public interface IShape
    {
        double CalculateArea();
    }

    public class Circle : IShape
    {
        public double Radius { get; set; }
        public double CalculateArea() => Math.PI * Radius * Radius;
    }

    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double CalculateArea() => Width * Height;
    }

   
    class IShape1
    {
        public static void M1()
        {
            IShape circle = new Circle { Radius = 5 };
            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");

            IShape rectangle = new Rectangle { Width = 4, Height = 6 };
            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
        }
    }
}//IShape1.M1();
