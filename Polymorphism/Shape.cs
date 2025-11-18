using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Polymorphism
{
    public class Shape
    {
        public string color = "red";
        public bool filled = true;

        public Shape()
        {
        }

        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }

        public string GetColor()
        {
            return color;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public bool IsFilled()
        {
            return filled;
        }

        public void SetFilled(bool filled)
        {
            this.filled = filled;
        }

        public virtual double GetArea()
        {
            return 0.0;
        }

        public virtual double GetPerimeter()
        {
            return 0.0;
        }

        public override string ToString()
        {
            return $"Shape[color={color}, filled={filled}]";
        }
    }

    public class Circle : Shape
    {
        public double radius;
        public Circle() : base()
        {
            radius = 1.0;
        }
        public Circle(double radius) : base()
        {
            this.radius = radius;
        }
        public Circle(double radius, string color, bool filled) : base(color, filled)
        {
            this.radius = radius;
        }
        public double GetRadius()
        {
            return radius;
        }
        public void SetRadius(double radius)
        {
            this.radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
        public override double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }
        public override string ToString()
        {
            return $"Circle[radius={radius}, color={color}, filled={filled}]";
        }
    }

public class Rectangle : Shape
    {
        public double width;
        public double length;
        public Rectangle() : base()
        {
            width = 1.0;
            length = 1.0;
        }
        public Rectangle(double width, double length) : base()
        {
            this.width = width;
            this.length = length;
        }
        public Rectangle(double width, double length, string color, bool filled) : base(color, filled)
        {
            this.width = width;
            this.length = length;
        }
        public double GetWidth()
        {
            return width;
        }
        public void SetWidth(double width)
        {
            this.width = width;
        }
        public double GetLength()
        {
            return length;
        }
        public void SetLength(double length)
        {
            this.length = length;
        }
        public override double GetArea()
        {
            return width * length;
        }
        public override double GetPerimeter()
        {
            return 2 * (width + length);
        }
        public override string ToString()
        {
            return $"Rectangle[width={width}, length={length}, color={color}, filled={filled} ]";
        }
    }

    public class Square : Rectangle
    {
        public Square() : base()
        {
        }
        public Square(double side) : base(side, side)
        {
        }
        public Square(double side, string color, bool filled) : base(side, side, color, filled)
        {
        }
        public double GetSide()
        {
            return GetWidth();
        }
        public void SetSide(double side)
        {
            SetWidth(side);
            SetLength(side);
        }
        public override string ToString()
        {
            return $"Square[side={GetSide()}, color={color}, filled={filled}]";
        }
    }
    public class ShapeTest
    {
        public static void S1()
        {
            Shape shape1 = new Circle(5.0, "blue", true);
            Console.WriteLine(shape1.ToString());
            Console.WriteLine($"Area: {shape1.GetArea()}");
            Console.WriteLine($"Perimeter: {shape1.GetPerimeter()}");

            Shape shape2 = new Rectangle(4.0, 6.0, "green", false);
            Console.WriteLine(shape2.ToString());
            Console.WriteLine($"Area: {shape2.GetArea()}");
            Console.WriteLine($"Perimeter: {shape2.GetPerimeter()}");

            Shape shape3 = new Square(3.0, "yellow", true);
            Console.WriteLine(shape3.ToString());
            Console.WriteLine($"Area: {shape3.GetArea()}");
            Console.WriteLine($"Perimeter: {shape3.GetPerimeter()}");
        }
    }
}   
