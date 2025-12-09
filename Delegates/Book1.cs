using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Delegates
{
    class Book1
    {
        public int Id;
        public string Title;

        public Book1(int id, string title)
        {
            Id = id;
            Title = title;
        }
    }

    class BookCollection
    {
        public static void M1()
        {
            IList<Book1> books = new List<Book1>();

            books.Add(new Book1(1, "C# Basics"));
            books.Add(new Book1(2, "OOP Concepts"));
            books.Add(new Book1(3, "ASP.NET Core"));

            foreach (var book in books)
            {
                Console.WriteLine($"{book.Id} - {book.Title}");
            }
            Console.WriteLine("----------------------------------------------------");
            books.RemoveAt(1);
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Id} - {book.Title}");
            }
            Console.WriteLine("----------------------------------------------------");
            Book1 b = books.FirstOrDefault(ob => ob.Title == "OOP Concepts");
            books.Remove(b);
        }
    }
}