using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Static_Keyword
{
    // Singleton Class
    public class A
    {
        private static A ob = null; // static variable to hold the single object

        public int Id { get; set; } // property to store ID

        private A() { } // private constructor – prevents object creation from outside

        private A(int id) { this.Id = id; } // private constructor with parameter

        // static method to get object (no parameter)
        public static A GetObject()
        {
            if (ob == null)
            {
                ob = new A(); // create the object only once
            }
            return ob; // return the same object every time
        }

        // static method to get object (with parameter)
        public static A GetObject(int id)
        {
            if (ob == null)
            {
                ob = new A(); // create the object if not created yet
            }
            ob.Id = id; // set the Id for the existing object
            return ob; // return the same object
        }

        // override ToString() to display object information
        public override string ToString()
        {
            return $"A[Id : {this.Id}]";
        }
    }

    // Another class that uses Singleton class A
    public class App1
    {
        public static void M1()
        {
   
            A ob = A.GetObject();      // first call -> creates object
            Console.WriteLine(ob);     // prints A[Id : 0]

            A ob1 = A.GetObject(89);   // second call -> reuses same object, changes Id
            Console.WriteLine(ob1);    // prints A[Id : 89]

            Console.WriteLine("+++++++++++++++++++++");

            Console.WriteLine(ob);     // prints A[Id : 89] again (same object)
        }
    }
}
