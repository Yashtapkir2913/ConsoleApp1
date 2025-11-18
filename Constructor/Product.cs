using ConsoleApp1.Constructor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Constructor
{
    class Product
    {
        public int productId;
        public string productName;
        public decimal price;
        public string brand;

        // Default constructor
        public Product()
        {
            this.productId = 1;
            this.productName = "Default Product";
            this.price = 1000;
            this.brand = "Generic";
        }

        // Constructor with 2 parameters
        public Product(int productId, string productName)
        {
            this.productId = productId;
            this.productName = productName;
        }

        // Constructor with 3 parameters
        public Product(int productId, string productName, decimal price) : this(productId, productName)
        {
            this.price = price;
        }

        // Constructor with 4 parameters
        public Product(int productId, string productName, decimal price, string brand) : this(productId, productName, price)
        {
            this.brand = brand;
        }

        // Method to show product details
        public void ShowDetails()
        {
            Console.WriteLine($"Product ID: {productId}, Name: {productName}, Price: {price}, Brand: {brand}");
        }

        // ToString()
        public override string ToString()
        {
            return $"Product [ID: {productId}, Name: {productName}, Price: {price}, Brand: {brand}]";
        }
    }
}

//Product p1 = new Product();
//p1.ShowDetails();

//Product p2 = new Product(101, "Laptop");
//p2.ShowDetails();

//Product p3 = new Product(102, "Smartphone", 45000);
//p3.ShowDetails();

//Product p4 = new Product(103, "Refrigerator", 70000, "LG");
//p4.ShowDetails();
