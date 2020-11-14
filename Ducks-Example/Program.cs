using Ducks_Example.entities;
using Ducks_Example.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //var ducks = GetDucks();

            //Console.WriteLine();
            //Console.WriteLine("DuckComparerBySize");
            //DuckComparerBySize sizeComparer = new DuckComparerBySize();

            //ducks.Sort(sizeComparer);
            //PrintDucks(ducks);

            //Console.WriteLine();
            //Console.WriteLine("DuckComparerByKind");
            //DuckComparerByKind kindComparer = new DuckComparerByKind();

            //ducks.Sort(kindComparer);
            //PrintDucks(ducks);

            //DuckComparer duckComparer = new DuckComparer();

            //Console.WriteLine();
            //Console.WriteLine("DuckComparer - KindThenSize");
            //duckComparer.sortBy = SortCriteria.KindThenSize;
            //ducks.Sort(duckComparer);
            //PrintDucks(ducks);

            //Console.WriteLine();
            //Console.WriteLine("DuckComparer - SizeThenKind");
            //duckComparer.sortBy = SortCriteria.SizeThenKind;
            //ducks.Sort(duckComparer);
            //PrintDucks(ducks);

            var ducks = GetDucks();

            IEnumerable<Bird> upCastingDucks = ducks;

            List<Bird> birds = new List<Bird>();
            birds.Add(new Bird() { Name = "Feathers" });
            birds.AddRange(upCastingDucks);
            birds.Add(new Penguin() { Name = "George" });

            foreach (var item in birds)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        public static List<Duck> GetDucks()
        {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck() { Kind = KindOfDuck.Mallard, Size = 17 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 18 },
                new Duck() { Kind = KindOfDuck.Decoy, Size = 14 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 11 },
                new Duck() { Kind = KindOfDuck.Mallard, Size = 14 },
                new Duck() { Kind = KindOfDuck.Decoy, Size = 13 },
            };

            return ducks;
        }

        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
                Console.WriteLine(duck);
            Console.WriteLine("End of Ducks");
        }
    }
}
