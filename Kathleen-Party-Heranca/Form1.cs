using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kathleen_Party_Heranca
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        AnniversaryParty anniversaryParty;
        public Form1()
        {
            InitializeComponent();

            dinnerParty = new DinnerParty((int)numericDinner.Value, healthyDinner.Checked, fancyDinner.Checked);
            DisplayDinnerPartyCost();

            anniversaryParty = new AnniversaryParty((int)numericAnniversary.Value, fancyAnniversary.Checked, txtCakeWriting.Text);
            DisplayAnniversaryPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            dinnerParty.CalculateCostOfDecorations(fancyDinner.Checked);
            decimal CostDinner = dinnerParty.CalculateCost();
            txtCostDinner.Text = CostDinner.ToString("c");
        }

        private void numericDinner_ValueChanged_1(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericDinner.Value;
             DisplayDinnerPartyCost();
        }

        private void fancyDinner_CheckedChanged_1(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(fancyDinner.Checked);
            DisplayDinnerPartyCost();
        }

        private void healthyDinner_CheckedChanged_1(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(healthyDinner.Checked);
            DisplayDinnerPartyCost();
        }

        private void numericAnniversary_ValueChanged(object sender, EventArgs e)
        {
            anniversaryParty.NumberOfPeople = (int)numericAnniversary.Value;
            DisplayAnniversaryPartyCost();
        }

        private void fancyAnniversary_CheckedChanged(object sender, EventArgs e)
        {
            anniversaryParty.CalculateCostOfDecorations(fancyAnniversary.Checked);
            DisplayAnniversaryPartyCost();
        }

        private void DisplayAnniversaryPartyCost()
        {
            anniversaryParty.CalculateCostOfDecorations(fancyAnniversary.Checked);
            txtCakeWriting.Text = anniversaryParty.CakeWriting;
            decimal CostAnni = anniversaryParty.CalculateCost();
            txtCostAnniversary.Text = CostAnni.ToString("c");
        }

        private void txtCakeWriting_TextChanged(object sender, EventArgs e)
        {
            anniversaryParty.CakeWriting = txtCakeWriting.Text;
            DisplayAnniversaryPartyCost();
        }
    }
}

