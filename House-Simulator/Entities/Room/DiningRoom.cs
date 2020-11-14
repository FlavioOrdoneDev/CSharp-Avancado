using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Simulator.Entities.Room
{
   public class DinningRoom : Room
    {
        public DinningRoom(string name, string decoration)
            :base(name, decoration)
        {
            this.name = name;
            this.decoration = decoration;
        }

        private string name;

        private string decoration;

        public string Decoration { get { return decoration; } }

        public override string Description
        {
            get { return Decoration; }
        }
    }
}
