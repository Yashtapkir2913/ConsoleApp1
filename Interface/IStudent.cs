using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface
{
    public interface IStudent
    {
        int Id { get; set; }
        string Name { get; set; }
        void Display();
    }

    public class Student : IStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void Display() => Console.WriteLine($"ID: {Id}, Name: {Name}");
    }

   
    class IStudent1
    {
        public static void M1()
        {
            IStudent student = new Student { Id = 101, Name = "Yash" };
            student.Display();
        }
    }
}//IStudent1.M1();
