using House_Simulator.Entities.Outside;
using House_Simulator.Entities.Room;
using House_Simulator.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_Simulator
{
    public partial class Form1 : Form
    {
        Location currentLocation;
        RoomWithDoor livingRoom;
        RoomWithDoor kitchen;
        Room dinningRoom;

        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        Outside garden;


        public Form1()
        {
            
            InitializeComponent();
            CreateObjects();
            MoveToANewLocation(livingRoom);
        }

        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Living Room", "an antique carpet", "an oak door with a brass knob");
            kitchen = new RoomWithDoor("Kitchen", "stainless steel apliances", "a screen door");
            dinningRoom = new Room("Dinning Room", "a crystal chandelier");

            frontYard = new OutsideWithDoor("Front Yard", false, "an oak door with a brass knob");
            backYard = new OutsideWithDoor("Back Yard", true, "a screen door");
            garden = new Outside("Garden", false);

            dinningRoom.Exits = new Location[] { livingRoom, kitchen };
            livingRoom.Exits = new Location[] { frontYard, dinningRoom };
            kitchen.Exits = new Location[] { dinningRoom, backYard};
            frontYard.Exits = new Location[] { livingRoom, garden};
            backYard.Exits = new Location[] { kitchen, garden };
            garden.Exits = new Location[] { backYard, frontYard};

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }

        private void MoveToANewLocation(Location newLocation)
        {
            currentLocation = newLocation;

            comboBoxExits.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
            {
                comboBoxExits.Items.Add(currentLocation.Exits[i].Name);
            }
            comboBoxExits.SelectedIndex = 0;

            txtDesciption.Text = currentLocation.Description;

            if (currentLocation is IHasExteriorDoor)
                btnGoThroughTheDoor.Visible = true;
            else
                btnGoThroughTheDoor.Visible = false;
        }

        private void btnGoHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[comboBoxExits.SelectedIndex]);
        }

        private void btnGoThroughTheDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }
    }
}
