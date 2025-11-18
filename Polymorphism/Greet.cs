using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Polymorphism
{
    public class Greet
    {
        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }

        public void SayHello(string name)
        {
            Console.WriteLine("Hello " + name + "!");
        }

        public void SayHello(string name, int age)
        {
            Console.WriteLine("Hello " + name + ", Age: " + age);
        }
    }

    public class GreetExample
    {
        public static void G1()
        {
            Greet greeter = new Greet();
            greeter.SayHello();
            greeter.SayHello("Yash Tapkir");
            greeter.SayHello("Shreyas", 28);
        }
    }
}//GreetExample.G1();
