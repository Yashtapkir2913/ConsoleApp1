using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Inheritance
{
    public class Address
    {
        public int Id { get; set; }
        public string Landmark { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        //constructor
        public Address() : this(1, "near by Statue of Sambhaji maharaj Deccan", " pune", "Mh", "411004") { }

        public Address(int id, string landmark, string city, string state, string zipCode)
        {
            this.Id = id;
            this.Landmark = landmark;
            this.City = city;
            this.State = state;
            this.ZipCode = zipCode;
        }
        //tostring 
        public override string ToString()
        {
            return $"Address[Id : {Id} , Landmark : {Landmark} ,City : {City}, State :  {State}, ZipCode : {ZipCode}  ]";
        }
    }

    public class Emp
    {
        public int EId { get; set; }
        public string Name { get; set; }

        public Address Address { get; set; } = new Address(); //tigthly Couple 

        public Emp() : this(11, "Raju")
        {

        }
        public Emp(int id, string name, Address address)
        {
            this.EId = id;
            this.Name = name;
            this.Address = address;
        }
        public Emp(int id, string name)
        {
            this.EId = id;
            this.Name = name;
            //Address = new Address();
        }

        //tostring 
        public override string ToString()
        {
            return $"Employee[ EId :{EId} , Name :{Name} , {Address}]";
        }
    }
    public class App
    {

        public static void M1()
        {
            Emp emp = new Emp();
            Console.WriteLine(emp);
        }
    }

}
