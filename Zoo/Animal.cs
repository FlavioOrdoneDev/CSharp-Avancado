using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Animal
    {
        public string Name { get; set; }
        public string Food { get; set; }
        public int Hunger { get; set; }
        public string Boundaries { get; set; }
        public string Location { get; set; }

        public virtual void MakeNoise()
        {
            Console.WriteLine("O Animal {0} está fazendo barulho...", this.Name);
        }
        public virtual void Eat()
        {
            Console.WriteLine("O Animal {0} está comendo {1}...", this.Name, this.Food);
        }

        public virtual void Sleep()
        {
            Console.WriteLine("O Animal {0} está dormindo...", this.Name);
        }

        public virtual void Roam()
        {
            Console.WriteLine("O Animal {0} está vagando...", this.Name);
        }
    }
}
