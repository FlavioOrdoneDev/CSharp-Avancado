using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClownExample
{
    public class FunnyFunny : IClown
    {
        public FunnyFunny(string funnyThink)
        {
            this.funnyThink = funnyThink;
        }

        protected string funnyThink { get; set; }
        public string FunnyThinkIHave { get { return "Fom fom!!! Eu tenho uma " + funnyThink; } }

        public void Honk()
        {
            Console.WriteLine(this.funnyThink);
        }
    }
}
