using ConsoleApp1.Constructor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Constructor
{
    using System;

    class Employee1
    {
        public int empId;
        public string empName;
        public decimal salary;
        public string department;
        public string city;

        // Default constructor
        public Employee1()
        {
            this.empId = 1;
            this.empName = "Default Employee";
            this.salary = 30000;
            this.department = "General";
            this.city = "Pune";
        }

        // Constructor with 1 parameter
        public Employee1(int empId)
        {
            this.empId = empId;
        }

        // Constructor with 2 parameters
        public Employee1(int empId, string empName) : this(empId)
        {
            this.empName = empName;
        }

        // Constructor with 3 parameters (id, name, salary)
        public Employee1(int empId, string empName, decimal salary) : this(empId, empName)
        {
            this.salary = salary;
        }

        // Constructor with 3 parameters (id, salary, name)
        public Employee1(int empId, decimal salary, string empName) : this(empId, empName, salary)
        { }

        // Constructor with 4 parameters (id, name, salary, department)
        public Employee1(int empId, string empName, decimal salary, string department) : this(empId, empName, salary)
        {
            this.department = department;
        }

        // Constructor with 4 parameters (id, name, salary, city)
        public Employee1(int empId, string empName, decimal salary, string department, string city) : this(empId, empName, salary, department)
        {
            this.city = city;
        }

        // Display details
        public void ShowDetails()
        {
            Console.WriteLine($"Employee ID: {empId}, Name: {empName}, Salary: {salary}, Department: {department}, City: {city}");
        }

        // Grade generation based on salary
        public string GenerateGrade()
        {
            if (salary >= 90000)
                return "Outstanding";
            else if (salary >= 75000)
                return "Excellent";
            else if (salary >= 60000)
                return "Good";
            else if (salary >= 40000)
                return "Average";
            else
                return "Needs Improvement";
        }

        public override string ToString()
        {
            return $"Employee [ID: {empId}, Name: {empName}, Salary: {salary}, Dept: {department}, City: {city}, Grade: {GenerateGrade()}]";
        }
    }
}
//// Default constructor
//Employee1 e1 = new Employee1(1, "yyhjhh");

//Console.WriteLine(e1.ToString());

////  Constructor with 1 parameter
//Employee1 e2 = new Employee1(101);
//e2.ShowDetails();
//Console.WriteLine();

////  Constructor with 2 parameters
//Employee1 e3 = new Employee1(102, "Yash Tapkir");
//e3.ShowDetails();
//Console.WriteLine();

//Employee1 e4 = new Employee1(103, "Riya Sharma", 55000);
//e4.ShowDetails();
//Console.WriteLine();

////  Constructor with 3 parameters (id, salary, name)
//Employee1 e5 = new Employee1(104, 75000, "Amit Kumar");
//e5.ShowDetails();
//Console.WriteLine();

////  Constructor with 4 parameters (id, name, salary, department)
//Employee1 e6 = new Employee1(105, "Sneha Patil", 90000, "HR");
//e6.ShowDetails();
//Console.WriteLine();

//// Constructor with 5 parameters (id, name, salary, department, city)
//Employee1 e7 = new Employee1(106, "Rohan Mehta", 95000, "IT", "Mumbai");
//e7.ShowDetails();
//Console.WriteLine(e7.ToString());