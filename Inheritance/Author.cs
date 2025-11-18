using ConsoleApp1.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Inheritance
{
    public class Author
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public char Gender { get; set; }

        public Author(string name, string email, char gender)
        {
            Name = name;
            Email = email;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"{Name} ({Gender}) at {Email}";
        }
    }
    public class Book : Author
    {
        public string BookName { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }

        public Book(string bookName, string name, string email, char gender, double price, int qty)
            : base(name, email, gender)
        {
            BookName = bookName;
            Price = price;
            Qty = qty;
        }

        public override string ToString()
        {
            return $"'{BookName}' by {base.ToString()}";
        }
    }

    class Author1
    {
        public static void A1()
        {
            Book book = new Book("C# Mastery", "Yash", "yash@example.com", 'm', 499.99, 10);
            Console.WriteLine(book.ToString());
          
        }
    }
}