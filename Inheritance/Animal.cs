using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Inheritance
{

    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal speaks");
        }
    }

    public class Dog : Animal
    {
        public override void Speak()
        {
            base.Speak();                 // calling base class method
            Console.WriteLine("Dog barks");
        }
    }

    class Animal1
    {
        public static void M1()
        {
            Dog d = new Dog();
            d.Speak();
        }
    }

}//Animal1.M1();
