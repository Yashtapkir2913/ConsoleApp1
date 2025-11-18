using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Polymorphism
{
    public class Printer
    {
        public void Print(int value)
        {
            Console.WriteLine("Integer: " + value);
        }

        public void Print(string value)
        {
            Console.WriteLine("String: " + value);
        }

        public void Print(double value)
        {
            Console.WriteLine("Double: " + value);
        }

        public void Print(bool value)
        {
            Console.WriteLine("Boolean: " + value);
        }
    }

    public class Printer1
    {
        public static void P1()
        {
            Printer p = new Printer();

            p.Print(10);            
            p.Print("Yash");       
            p.Print(12.75);         
            p.Print(true);
        }
    }

}// Printer1.P1();
