using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Canine
{
    public class Canine : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("O Canino {0} está comendo", this.Name);
        }

        public override void Sleep()
        {
            Console.WriteLine("O Canino {0} está dormindo", this.Name);
        }
    }
}
