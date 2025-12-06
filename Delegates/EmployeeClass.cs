using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Delegates
{
    class EmployeeClass : IComparable<EmployeeClass>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public EmployeeClass(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public int CompareTo(EmployeeClass other)
        {
            return this.Id.CompareTo(other.Id);
        }

        public override string ToString()
        {
            return $"EmployeeClass {{ Id={Id}, Name={Name}, Salary={Salary} }}";
        }
    }

    class EmpCls
    {
        public static void M1()
        {
            SortedSet<EmployeeClass> employees = new SortedSet<EmployeeClass>();

            employees.Add(new EmployeeClass(1, "Yash", 50000));
            employees.Add(new EmployeeClass(2, "Pande", 55000));
            employees.Add(new EmployeeClass(3, "Dheeraj", 60000));
            employees.Add(new EmployeeClass(4, "Aniket", 45000));
            employees.Add(new EmployeeClass(5, "Vaibhav", 70000));
            employees.Add(new EmployeeClass(6, "Omkar", 65000));
            employees.Add(new EmployeeClass(7, "Ganesh", 48000));

            foreach (var emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
