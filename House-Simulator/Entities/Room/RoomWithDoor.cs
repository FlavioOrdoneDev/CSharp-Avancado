using House_Simulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace House_Simulator.Entities.Room
{
    public class RoomWithDoor : Room, IHasExteriorDoor
    {
        public RoomWithDoor(string name, string decoration, string doorDescription )
            :base(name, decoration)
        {
            this.doorDescription = doorDescription;
        }

        private string doorDescription;

        public virtual string DoorDescription { get { return doorDescription; } }

        private Location doorLocation;

        public virtual Location DoorLocation { get { return doorLocation; } set { doorLocation = value; } }
    }
}
