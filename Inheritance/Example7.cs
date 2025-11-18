using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Inheritance
{
    using System;

    public class Example7 //Person class
    {
        public void Greet()
        {
            Console.WriteLine("Hello!");
        }
    }

    public class Teacher : Example7
    {
        public void Teach()
        {
         
            Greet();
            Console.WriteLine("Teaching...");
        }
    }

    class Person11
    {
        public static void M1()
        {
            Teacher t = new Teacher();
            t.Teach();
        }
    }

}// Person11.M1();
