using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm farm = new Farm(30, 30);            
            
            int howManyBags = farm.BagsOfFeed;
            Console.WriteLine("I need {0} bags of feed for {1} cow(s)", howManyBags, farm.NumberOfCows);

            Console.ReadKey();
            
        }
    }
}
