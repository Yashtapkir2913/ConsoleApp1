using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Constructor
{
    using System;
        public class House
        {
            public int houseNo { get; set; }
            public string ownerName { get; set; }
            public string address { get; set; }

            public House()
            {
                houseNo = 101;
                ownerName = "Ravi";
                address = "Pune";
            }

            public House(int houseNo, string ownerName, string address)
            {
                this.houseNo = houseNo;
                this.ownerName = ownerName;
                this.address = address;
            }

            public override string ToString()
            {
                return $"House [No: {houseNo}, Owner: {ownerName}, Address: {address}]";
            }
        }

        public class HouseTest
        {
            public static void H1()
            {
                House h1 = new House();
                Console.WriteLine(h1);

                Console.WriteLine("-------------------------");

                House h2 = new House(202, "Neha", "Mumbai");
                Console.WriteLine(h2);
            }
        }

}
//HouseTest.H1();
