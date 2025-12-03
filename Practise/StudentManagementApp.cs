using System;

namespace ConsoleApp1.Practise
{
    //Example of Partial Class
 
    public partial class StudentManagementApp
    {
        public int RollNo;
        public string Name;
        public string Course;

        public void ShowBasicInfo()
        {
            Console.WriteLine($"Roll No: {RollNo}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Course: {Course}");
        }
    }

    public partial class StudentManagementApp
    {
        public int Marks1;
        public int Marks2;
        public int Marks3;

        public int CalculateTotal()
        {
            return Marks1 + Marks2 + Marks3;
        }

        public void ShowResult()
        {
            int total = CalculateTotal();
            Console.WriteLine($"Total Marks: {total}");

        }
    }
    public class StudentInfoDisplay
    {
        public static void M1()
        {
            StudentManagementApp student = new StudentManagementApp();
            student.RollNo = 101;
            student.Name = "Yash";
            student.Course = "C# Basics";

            student.Marks1 = 60;
            student.Marks2 = 55;
            student.Marks3 = 50;

            student.ShowBasicInfo();
            student.ShowResult();

        }
    }
}