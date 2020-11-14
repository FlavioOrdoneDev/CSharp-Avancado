using ClownExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClownExample
{
    class Program
    {
        static void Main(string[] args)
        {
            TallGuy tallGuy = new TallGuy() { Name = "Flávio", Height = 1.87 };
            tallGuy.ThalkAboutYourself();
            tallGuy.Honk();

            ScaryScary fingersTheClown = new ScaryScary("big shoes", 14);
            FunnyFunny someFunnyClown = fingersTheClown;
            someFunnyClown.Honk();
            IScaryClown someOtherScaryClown = someFunnyClown as ScaryScary;

            string scaryThing = someOtherScaryClown.ScaryThingIHave;
            Console.WriteLine(scaryThing);
            someOtherScaryClown.ScaryLittleChildren();
            someOtherScaryClown.Honk();

            Console.ReadKey();
        }
    }
}
