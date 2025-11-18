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
        public class Counter
        {
            public static int count = 0;   

            public Counter()
            {
                count++;   
                Console.WriteLine("Object created. Current count: " + count);
            }

            public static void ShowTotalObjects()
            {
                Console.WriteLine("Total objects created: " + count);
            }

            public class CounterProgram
            {
                public static void C1()
                {
                    Counter c1 = new Counter();
                    Counter c2 = new Counter();
                    Counter c3 = new Counter();

                    Counter.ShowTotalObjects();
                }
            }
        }
    }

}
//CounterProgram.C1();
