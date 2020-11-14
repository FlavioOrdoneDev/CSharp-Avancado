using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewelry
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner owner = new Owner();
            Safe safe = new Safe();

            JewelThief jewerThief = new JewelThief();
            jewerThief.OpenSafe(safe, owner);

            Console.ReadKey();
        }
    }
}
