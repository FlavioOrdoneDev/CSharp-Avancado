using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewelry
{
    public class JewelThief : Locksmith
    {
        private Jewels stolenJewels = null;
        public override void ReturnContents(Jewels safaContents, Owner owner)
        {
            stolenJewels = safaContents;
            Console.WriteLine("I'm stealing the contents! " + stolenJewels.Sparkle());
        }
    }
}
