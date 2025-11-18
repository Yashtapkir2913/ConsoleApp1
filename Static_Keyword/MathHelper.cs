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
        public static class MathHelper
        {
            public static int Add(int a, int b)
            {
                return a + b;
            }

            public static int Subtract(int a, int b)
            {
                return a - b;
            }
        }
        public class MyClass
        {
            public static void M2()
            {
                Console.WriteLine("Addition: " + MathHelper.Add(10, 5));
                Console.WriteLine("Subtraction: " + MathHelper.Subtract(10, 5));
            }
        }
    }

}
//MyClass.M2();
