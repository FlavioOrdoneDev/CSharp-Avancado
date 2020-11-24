using System;
using System.Linq;
using System.Collections.Generic;

namespace AppLinqLambda
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category(1, "Tools", 2);
            Category c2 = new Category(2, "Computers", 1);
            Category c3 = new Category(3, "Eletronics", 1);

            List<Product> products = new List<Product>()
            {
                new Product(1, "Computer", 1100.00, c2),
                new Product(2, "Hammer", 90.00, c1),
                new Product(3, "TV", 1700.00, c3),
                new Product(4, "Notebook", 1300.00, c2),
                new Product(5, "Saw", 80.00, c1),
                new Product(6, "Tablet", 700.00, c2),
                new Product(7, "Camera", 700.00, c3),
                new Product(8, "Printer", 350.00, c3),
                new Product(9, "MacBook", 1800.00, c2),
                new Product(10, "Sound Bar", 700.00, c3),
                new Product(11, "Level", 70.00, c1)
            };

            // Tier 1 and price < 900
            
            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.00);
            Print("Tier 1 and price < 900", r1);

            
            // Names of products from tools

            var r2 = products.Where(p => p.Category.Name.Contains("Tools")).Select(p => p.Name);
            Print("Names of products from tools", r2);


            // Products starts with 'C' and annonymous objects

            var r3 = products.Where(p => p.Name.StartsWith("C")).Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name});
            Print("Products starts with 'C'", r3);


            // Tier 1 order by price then by name

            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("Tier 1 order by price then by name", r4);


            // Skip two take four

            var r5 = r4.Skip(2).Take(4);
            Print("Skip two take four", r5);


            // Take the first element

            var r6 = products.FirstOrDefault();
            Console.WriteLine("Take the first or default element: " + r6);
            Console.WriteLine();


            // Take the first or default where price > 3000.00

            var r7 = products.Where(p => p.Price > 3000.00).FirstOrDefault();
            Console.WriteLine("Take the first or default where price > 3000.00: " + r7);
            Console.WriteLine();


            // Single or default test 1

            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or default test 1: " + r8);
            Console.WriteLine();


            // Single or default test 2

            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or default test 2: " + r9);
            Console.WriteLine();


            // Max price

            var r10 = products.Max(p => p.Price);
            Console.WriteLine("Max price: " + r10);
            Console.WriteLine();


            // Min price

            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Max price: " + r11);
            Console.WriteLine();


            // Sum all products where Category equals 1

            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Sum all products where Category equals 1: " + r12);
            Console.WriteLine();


            // Average all products where Category equals 1

            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Average all products where Category equals 1: " + r13);
            Console.WriteLine();


            // Average all products where Category equals 5 Default if empty

            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average all products where Category equals 5 Default if empty: " + r14);
            Console.WriteLine();


            // Category 1 agregate sum

            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((x, y) => x + y);
            Console.WriteLine("Category 1 agregate sum: " + r15);
            Console.WriteLine();

            // Category 5 agregate sum if empty

            var r16 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Category 1 agregate sum if empty: " + r16);
            Console.WriteLine();


            // Group by category

            var r17 = products.GroupBy(p => p.Category);
            foreach (IGrouping<Category, Product> group in r17)
            {
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
