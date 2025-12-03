using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Practise
{

    public partial class Student01
    {
        public string Name;

        public void PrintName()
        {
            Console.WriteLine("Name: " + Name);
        }
    }

    public partial class Student01
    {
        public int Age;

        public void PrintAge()
        {
            Console.WriteLine("Age: " + Age);
        }

        public void ShowDetails()
        {
            PrintName();
            PrintAge();
        }

    }
    public class PartialClassDemo
    {
        public static void M1()
        {
            Student01 student = new Student01();
            student.Name = "Yash";
            student.Age = 21;
            student.ShowDetails();
        }
    }
}