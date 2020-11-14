using ClownExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClownExample
{
    public class ScaryScary : FunnyFunny, IScaryClown
    {
        public ScaryScary(string funnyThink, int numberOfScaryThings)
            :base(funnyThink)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }

        private int numberOfScaryThings { get; set; }

        public string ScaryThingIHave { get { return "Eu tenho " + numberOfScaryThings.ToString() + " aranhas"; } }

        public void ScaryLittleChildren()
        {
            Console.WriteLine("Buh!!! Peguei vocês...");
        }
    }
}
