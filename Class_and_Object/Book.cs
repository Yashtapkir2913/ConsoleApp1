using ConsoleApp1.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Class
{
    public class Book
    {
        public string title;
        public string author;
        public double price;

        public void ShowBook()
        {
            Console.WriteLine($"Book: {title}, Author: {author}, Price: ₹{price}");
        }
    }

}
//Book B1 = new Book();
//B1.title = "The Room 105";
//B1.author = "Chetan Bhagat";
//B1.price = 350;

//Book B2 = new Book();
//B2.title = "Freedom Fighter"
//B2.author = "Rashmi Bansal";
//B2.price = 400;

//Book B3 = new Book();
//B3.title = "Atomic Habits";
//B3.author = "James Clear";
//B3.price = 500;
