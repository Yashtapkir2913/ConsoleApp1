using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Abstraction
{

    abstract class Animal1
    {
        
        public abstract void Sound();
    }

    class Dog : Animal1
    {
        public override void Sound()
        {
            Console.WriteLine("Dog barks!");
        }
    }

    class Cat : Animal1
    {
        public override void Sound()
        {
            Console.WriteLine("Cat meows!");
        }
    }

    class Animal11
    {
        public static void M1()
        {
            Animal1 a= new Dog(); 
            a.Sound(); 

            Animal1 a2 = new Cat();
            a2.Sound();   
        }
    }

}
