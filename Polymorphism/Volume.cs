using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Polymorphism
{
    public class Volume
    {
       
        public double Calculate(int side)
        {
            return side * side * side;
        }

        
        public double Calculate(double radius, double height)
        {
            return Math.PI * radius * radius * height;
        }

       
        public double Calculate(double l, double w, double h)
        {
            return l * w * h;
        }
    }

    public class VolumeExample
    {
        public static void V1()
        {
            Volume volume = new Volume();
            double cubeVolume = volume.Calculate(3);
            Console.WriteLine("Volume of Cube: " + cubeVolume);
            double cylinderVolume = volume.Calculate(2.5, 7.0);
            Console.WriteLine("Volume of Cylinder: " + cylinderVolume);
            double boxVolume = volume.Calculate(4.0, 5.0, 6.0);
            Console.WriteLine("Volume of Box: " + boxVolume);
        }
    }
}//VolumeExample.V1();
