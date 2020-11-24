using System;
using System.Collections.Generic;
using System.Text;

namespace AppLinqLambda
{
    public class Product
    {
        public Product(int id, string name, double price, Category category)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2") + ", " + Category.Name + ", " + Category.Tier;
        }
    }
}
