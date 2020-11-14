using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Hippo : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("{0} está fazendo barulho...", this.Name);
        }

        public override void Eat()
        {
            Console.WriteLine("{0} está comendo {1}...", this.Name, this.Food);
        }

        public override void Roam()
        {
            base.Roam();
        }

        public override void Sleep()
        {
            base.Sleep();
        }
    }
}
