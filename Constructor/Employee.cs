using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Constructor
{
    public class Employee
    {
        public int id;
        public string name;
        public decimal salary;

        public Employee()//default constructor
        {
            id = 101;
            name = "John Doe";
            salary = 50000.00m;
        }

        public Employee(int empId, string empName, decimal empSalary)// parameterized constructor
        {
            this.id = empId;
            this.name = empName;
            this.salary = empSalary;
        }
        public void Display()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Salary: " + salary);
        }

    }
    public class Emp1
    {
       public static void F1()
        {
            Employee emp1 = new Employee();
            emp1.Display();   // default constructor

            Employee emp2 = new Employee(102, "Jane Smith", 60000.00m);
            emp2.Display();  //parameterized constructor

        }
    }
}
//Emp1.F1();
