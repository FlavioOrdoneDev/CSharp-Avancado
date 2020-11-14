using House_Simulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Simulator.Entities.Outside
{
    public class Outside : Location
    {
        public Outside(string name, bool hot)
            :base(name)
        {
            this.hot = hot;
        }

        private bool hot { get; }

        public bool Hot { get { return hot; } }

        public override string Description
        {
            get 
            {
                string NewDescription = base.Description;
                if (hot)
                    NewDescription += "It's very hot.";
                return NewDescription;
            }
        }
    }
}
