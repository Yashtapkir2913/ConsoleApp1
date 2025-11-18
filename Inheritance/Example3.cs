using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Inheritance
{
    using System;

    public class Example3// Employee Class
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Example3(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"Name: {Name}, ID: {Id}");
        }
    }

    public class Manager : Example3
    {
        public int TeamSize { get; set; }

        public Manager(string name, int id, int teamSize) : base(name, id)
        {
            TeamSize = teamSize;
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"Name: {Name}, ID: {Id}, Team Size: {TeamSize}");
        }
    }

    class Employee11
    {
        public static void M1()
        {
            Example3 e = new Example3("Yash", 101);
            e.ShowDetails();

            Manager m = new Manager("Raj", 201, 8);
            m.ShowDetails();
        }
    }

}//Employee11.M1();
