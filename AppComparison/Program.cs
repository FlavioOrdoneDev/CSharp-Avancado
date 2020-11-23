using System;
using System.Collections.Generic;

namespace AppComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new Product("TV", 900.00));
            products.Add(new Product("Notebook", 1200.00));
            products.Add(new Product("Tablet", 450.00));

            products.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper())); // Comparison<T> comparison
            //products.Sort((p1, p2) => p1.Price.CompareTo(p2.Price));           

            foreach (var item in products)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }

    class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + ", Price: " + Price.ToString("F2");
        }
    }
}
