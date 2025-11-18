using ConsoleApp1.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Class
{
    public class Room
    {
        public int roomNumber;
        public string type;
        public double area;

        public void ShowRoom()
        {
            Console.WriteLine($"Room No: {roomNumber}, Type: {type}, Area: {area} sq.ft");
        }
    }

}
//Room R1 = new Room();
//R1.roomNumber = 1;
//R1.type = "Deluxe";
//R1.area = 350.5;
//R1.ShowRoom();

//Room R2 = new Room();
//R2.roomNumber = 2;
//R2.type = "Suite";
//R2.area = 500.0;
//R2.ShowRoom();

//Room R3 = new Room();
//R3.roomNumber = 3;
//R3.type = "Standard";
//R3.area = 250.75;
//R3.ShowRoom();



