using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Class
{
  public class Student1
    {
        public int rollNo;
        public string name;
        public string course;
        public void DisplayStudent()
        {
            Console.WriteLine($"Roll No: {rollNo}, Name: {name}, Course: {course}");
        }

    }
    public class stud1 { 
    public static void f2()
        {
            Student1 S2 = new Student1();
            S2.rollNo = 2;
            S2.name = "Riya";
            S2.course = "Computer Science";
            S2.DisplayStudent();
        }
    }
}
