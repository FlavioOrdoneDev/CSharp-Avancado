using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var shoes = GetShoes();

            PrintShoes(shoes);

            shoes.RemoveAt(4);

            PrintShoes(shoes);

            Shoe thirdShoe = shoes[3];
            Shoe secondShoe = shoes[2];
            
            shoes.Clear();

            shoes.Add(thirdShoe);
            shoes.Add(secondShoe);

            PrintShoes(shoes);

            if (shoes.Contains(secondShoe))
                Console.WriteLine("That's surprising.");

            Console.ReadKey();
        }

        public static List<Shoe> GetShoes()
        {
            List<Shoe> shoes = new List<Shoe>();

            shoes.Add(new Shoe(Style.Sneakers, "Black"));
            shoes.Add(new Shoe(Style.Clogs, "Brown"));
            shoes.Add(new Shoe(Style.Wingtips, "Black"));
            shoes.Add(new Shoe(Style.Loafers, "White"));
            shoes.Add(new Shoe(Style.Loafers, "Red"));
            shoes.Add(new Shoe(Style.Sneakers, "Green"));

            return shoes;
        }  
        
        private static void PrintShoes(List<Shoe> shoes)
        {
            foreach (var item in shoes)
            {
                Console.WriteLine("Style: " + item.Style + " Color: " + item.Color);
            }

            Console.WriteLine("Number of shoes: " + shoes.Count);
            Console.WriteLine();
        }
    }





    public class Shoe
    {
        public Shoe(Style style, string color)
        {
            this.Style = style;
            this.Color = color;
        }

        public Style Style;
        public string Color;
    }

    public enum Style
    {
        Sneakers,
        Loafers,
        Sandals,
        Flipflops,
        Wingtips,
        Clogs
    }

}
