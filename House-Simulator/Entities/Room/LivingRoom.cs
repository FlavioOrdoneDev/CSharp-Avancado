using House_Simulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Simulator.Entities.Room
{
    public class LivingRoom : RoomWithDoor, IHasExteriorDoor
    {
        public LivingRoom(string name, string decoration, string doorDescription)
            : base(name, decoration, doorDescription)
        {
            this.doorDescription = doorDescription;
        }

        private string doorDescription;

        public override string DoorDescription { get { return doorDescription; } }

        private Location doorLocation;

        public override Location DoorLocation { get { return doorLocation; } set { doorLocation = value; } }
    }
}
