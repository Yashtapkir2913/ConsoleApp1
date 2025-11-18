using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Inheritance
{
    using System;

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public class Student : Person
    {
        public string Grade { get; set; }

        public Student(string name, int age, string grade) : base(name, age)
        {
            Grade = grade;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Grade: {Grade}");
        }
    }

    class Person1
    {
        public static void M1()
        {
            Student s = new Student("Rahul", 20, "A");
            s.ShowDetails();
        }
    }

}//Person1.M1();
