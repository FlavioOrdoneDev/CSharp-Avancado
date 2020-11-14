using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Canine
{
    public class Dog : Canine
    {
        public override void MakeNoise()
        {
            Console.WriteLine("{0} está fazendo barulho...", this.Name);
        }

        public override void Eat()
        {
            base.Eat();
        }

        public override void Sleep()
        {
            base.Sleep();
        }

        public override void Roam()
        {
            base.Roam();
        }
    }
}
