using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Inheritance
{
    public class Circle
    {
        private double radius = 1.0;
        private string color = "red";

        // Constructors
        public Circle() { }
        public Circle(double radius) { this.radius = radius; }
        public Circle(double radius, string color) { this.radius = radius; this.color = color; }

        // Getters / Setters
        public double GetRadius() => radius;
        public void SetRadius(double r) => radius = r;
        public string GetColor() => color;
        public void SetColor(string c) => color = c;

        // Behavior
        public double GetArea() => Math.PI * radius * radius;
        public override string ToString() => $"Circle[radius={radius}, color={color}]";
    }

    public class Cylinder : Circle
    {
        private double height = 1.0;

        // Constructors
        public Cylinder() : base() { }
        public Cylinder(double radius) : base(radius) { }                      // radius, default height
        public Cylinder(double radius, double height) : base(radius) { this.height = height; }
        public Cylinder(double radius, double height, string color) : base(radius, color) { this.height = height; }

        // Getter / Setter
        public double GetHeight() => height;
        public void SetHeight(double h) => height = h;

        // Behavior
        public double GetVolume() => GetArea() * height;
        public override string ToString() => $"Cylinder: subclass of {base.ToString()}, height={height}";
    }

    class NewProg
    {
        public static void M1()
        {
            var c1 = new Circle();                         
            var c2 = new Circle(2.0);                     
            var c3 = new Circle(2.5, "blue");              

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3 + " Area=" + c3.GetArea());

            var cy1 = new Cylinder();                     
            var cy2 = new Cylinder(2.0);                   
            var cy3 = new Cylinder(2.5, 4.0);             
            var cy4 = new Cylinder(2.5, 5.0, "green");     

            Console.WriteLine(cy1);
            Console.WriteLine(cy2 + " Volume=" + cy2.GetVolume());
            Console.WriteLine(cy3 + " Volume=" + cy3.GetVolume());
            Console.WriteLine(cy4 + " Volume=" + cy4.GetVolume());
        }
    }
}
//NewProg.M1();
