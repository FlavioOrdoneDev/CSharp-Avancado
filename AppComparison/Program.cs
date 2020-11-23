using System;
using System.Linq;
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
            products.Add(new Product("Mouse", 50.00));
            products.Add(new Product("HD", 81.00));


            // Comparison<T> comparison

            products.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper())); 

            foreach (var item in products)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();



            // Action - Aumentar o valor dos produtos em 10% - Regra tem que retornar void
            Console.WriteLine("Action");

            Action<Product> action = p => { p.Price += p.Price * 0.1; };

            products.ForEach(action);

            foreach (var item in products)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Func - Gerar nova lista em caixa alta - Regra retorna valor
            Console.WriteLine("Func");

            Func<Product, string> func = p => p.Name.ToUpper();

            List<string> newProducts = products.Select(p => p.Name.ToUpper()).ToList();
            
            foreach (var item in newProducts)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();



            // Predicate - Remover todos os produtos com valores acima de 100.00 - Regra retorna um bool
            Console.WriteLine("Predicate");

            products.RemoveAll(ProductRemove);

            foreach (var item in products)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.ReadKey();
        }        

        public static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }

        public static string NameToUpper(Product p)
        {
            return p.Name.ToUpper();
        }

        public static bool ProductRemove(Product p)
        {
            return p.Price >= 100.00;
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
