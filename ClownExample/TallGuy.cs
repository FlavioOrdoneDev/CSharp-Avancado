using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClownExample
{
    public class TallGuy : IClown
    {
        public string Name;
        public double Height;

        public string FunnyThinkIHave { get { return "big shoes";  } }

        public void Honk()
        {
            Console.WriteLine("Honk honk");
        }

        public void ThalkAboutYourself()
        {
            Console.WriteLine("Meu nome é " + Name + " e eu tenho " + Height + " de altura." );
        }
    }
}
