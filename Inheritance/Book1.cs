using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Inheritance
{
    using System;

    public class Book1
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book1(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }

    public class EBook : Book1
    {
        public double FileSize { get; set; }  

        public EBook(string title, string author, double fileSize)
            : base(title, author)  
        {
            FileSize = fileSize;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, File Size: {FileSize} MB");
        }
    }

    class Book11
    {
        public static void M1()
        {
            EBook ebook = new EBook("C# Basics", "John Smith", 2.5);
            ebook.ShowDetails();
        }
    }

}//Book11.M1();
