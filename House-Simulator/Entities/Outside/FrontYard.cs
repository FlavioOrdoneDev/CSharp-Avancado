using House_Simulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Simulator.Entities.Outside
{
    public class FrontYard : Outside
    {
        public FrontYard(string name, bool hot, string doorDescription)
            : base(name, hot)
        {
            this.doorDescription = doorDescription;
        }

        private string doorDescription;
        public string DoorDescription
        {
            get { return doorDescription; }
            set { doorDescription = value; }
        }

        private Location doorLocation;

        public Location DoorLocation
        {
            get { return doorLocation; }
            set { doorLocation = value; }
        }

        public override string Description => base.Description + "You see " + doorDescription + ".";
    }
}