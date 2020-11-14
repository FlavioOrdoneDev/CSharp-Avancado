using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Feline : Animal
    {
        public override void Roam()
        {
            Console.WriteLine("O Felino {0} está vagando...", this.Name);
        }
    }
}
