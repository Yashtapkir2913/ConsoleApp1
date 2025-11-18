using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Class
{
    public class Student
    {
        public int rollNo;
        public string name;
        public string course;

        public void DisplayStudent()
        {
            Console.WriteLine($"Roll No: {rollNo}, Name: {name}, Course: {course}");
        }
        
    }

}
//Student S1 = new Student();
//S1.rollNo = 1;
//S1.name = "Yash";
//S1.course = "Electronics";

//Student S2 = new Student();
//S2.rollNo = 2;
//S2.name = "Riya";
//S2.course = "Computer Science";

//Student S3 = new Student();
//S3.rollNo = 3;
//S3.name = "Aman";
//S3.course = "Mechanical";



