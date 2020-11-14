using House_Simulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Simulator.Entities.Room
{
    public class Kitchen : Room, IHasExteriorDoor
    {
        public Kitchen(string name, string decoration, string doorDescription)
            : base(name, decoration)
        {
            this.doorDescription = doorDescription;
        }

        private string doorDescription;

        public string DoorDescription { get { return doorDescription; } }

        private Location doorLocation;

        public Location DoorLocation { get { return doorLocation; } set { doorLocation = value; } }
    }
}
