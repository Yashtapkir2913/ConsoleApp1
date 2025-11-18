using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Constructor
{
    using System;

    namespace DemoProject.StaticExamples
    {
        public class Demo
        {
            public static int number;

           
            static Demo()
            {
                number = 100;
                Console.WriteLine("Static Number is: " +number);
            }

            // Instance constructor
            public Demo()
            {
                Console.WriteLine("Instance constructor called");
            }

            public static void ShowNumber()
            {
                Console.WriteLine("Static variable value: " + number);
            }
        }

        public class DemoProgram
        {
            public static void D1()
            {
                Demo.ShowNumber(); 
                Demo demo1 = new Demo(); 
                Demo demo2 = new Demo(); 
            }
        }
    }

}
//DemoProgram.D1();
