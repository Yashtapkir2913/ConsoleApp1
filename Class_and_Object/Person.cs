using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Class
{
    public class Person
    {
        public string name;
        public int age;
        public string city;

        public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {name}, {age} years old from {city}.");
        }
    }
}
//Person P1 = new Person();
//P1.name = "Alice";
//P1.age = 30;
//P1.city = "New York";
//P1.Introduce();

//Person P2 = new Person();
//P2.name = "Bob";
//P2.age = 25;
//P2.city = "Los Angeles";
//P2.Introduce();