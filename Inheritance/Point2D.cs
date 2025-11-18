using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Inheritance
{
    public class Point2D
    {
        private float x = 0.0f;
        private float y = 0.0f;

        // Default constructor
        public Point2D()
        {
        }

        // Parameterized constructor
        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        // Getters and Setters
        public float GetX()
        {
            return x;
        }

        public void SetX(float x)
        {
            this.x = x;
        }

        public float GetY()
        {
            return y;
        }

        public void SetY(float y)
        {
            this.y = y;
        }

        // Set both x and y
        public void SetXY(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        // Return array of x and y
        public float[] GetXY()
        {
            float[] arr = { x, y };
            return arr;
        }

        // ToString method
        public override string ToString()
        {
            return "(" + x + "," + y + ")";
        }
    }

    public class Point3D : Point2D
    {
        private float z = 0.0f;

        // Default constructor
        public Point3D() : base()
        {
        }

        // Parameterized constructor
        public Point3D(float x, float y, float z) : base(x, y)
        {
            this.z = z;
        }

        // Getters and Setters
        public float GetZ()
        {
            return z;
        }

        public void SetZ(float z)
        {
            this.z = z;
        }

        // Set all three values
        public void SetXYZ(float x, float y, float z)
        {
            SetXY(x, y); // call parent method
            this.z = z;
        }

        public float[] GetXYZ()
        {
            float[] arr = { GetX(), GetY(), z };
            return arr;
        }

        // ToString method
        public override string ToString()
        {
            return "(" + GetX() + "," + GetY() + "," + z + ")";
        }
    }

    class Test1
    {
        public static void P1()
        {
            Point2D p2 = new Point2D(3.5f, 5.5f);
            Console.WriteLine(p2.ToString());
            float[] xy = p2.GetXY();
            Console.WriteLine("XY: " + xy[0] + ", " + xy[1]);

            Point3D p3 = new Point3D(1.2f, 2.3f, 3.4f);
            Console.WriteLine(p3.ToString());
            float[] xyz = p3.GetXYZ();
            Console.WriteLine("XYZ: " + xyz[0] + ", " + xyz[1] + ", " + xyz[2]);
        }
    }
}
