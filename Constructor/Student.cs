using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Constructor
{
    using System;

    public class Student
    {
        public string name;           // instance variable
        public int rollNo;            
        public static string school;  // static variable (shared)
        public static int count = 0;  // static counter

        // Constructor
        public Student(string n, int r)
        {
            name = n;
            rollNo = r;
            count++;                 // increases for every object created
        }

        // Static method
        public static void DisplaySchool()
        {
            Console.WriteLine("School Name: " + school);
        }

        // Instance method
        public void DisplayDetails()
        {
            Console.WriteLine("Name: " + name + ", Roll No: " + rollNo);
        }
    }

    public class App
    {
        public static void M1()
        {
            //static field (same for all students)
            Student.school = "Green Valley High School";

            // 3 objects
            Student s1 = new Student("Riya", 1);
            Student s2 = new Student("Aman", 2);
            Student s3 = new Student("Yash", 3);

            Console.WriteLine("-------------------------------");

           
            s1.DisplayDetails();
            s2.DisplayDetails();
            s3.DisplayDetails();

            Console.WriteLine("-------------------------------");
            // call static method
            Student.DisplaySchool();

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Total Students Created: " + Student.count);
        }
    }

}
//App.M1();
