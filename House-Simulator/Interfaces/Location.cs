using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Simulator.Interfaces
{
    public abstract class Location
    {
        public Location(string name)
        {
            this.name = name;
        }

        public Location[] Exits;

        private string name;
        public string Name
        {
            get { return name; }
        }

        public virtual string Description
        {
            get
            {
                string description = "Você está no " + name + ". Você vê saida para os seguintes lugares: ";
                for (int i = 0; i < Exits.Length; i++)
                {
                    description += " " + Exits[i].Name;
                    if (i != Exits.Length - 1)
                        description += ",";
                }
                description += ".";

                return description;
            }
        }
    }
}
