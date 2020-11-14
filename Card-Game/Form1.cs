using Card_Game.entities;
using Card_Game.enuns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Card_Game
{
    public partial class Form1 : Form
    {
        Deck deck1;
        Deck deck2;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            ResetDeck(EDeck.Deck1);
            ResetDeck(EDeck.Deck2);

            RedrawDeck(EDeck.Deck1);
            RedrawDeck(EDeck.Deck2);
        }

        private void ResetDeck(EDeck deck)
        {
            if (deck == EDeck.Deck1)
            {
                int numberOfCards = random.Next(1, 11);
                deck1 = new Deck(new Card[] { });
                for (int i = 0; i < numberOfCards; i++)
                    deck1.Add(new Card((Suit)random.Next(4), (Value)random.Next(1, 14)));
                deck1.Sort();
            }
            else
            {
                deck2 = new Deck();
            }
        }

        private void RedrawDeck(EDeck deck)
        {
            if (deck == EDeck.Deck1)
            {
                txtDeck1.Items.Clear();
                foreach (string cardName in deck1.GetCardNames())
                    txtDeck1.Items.Add(cardName);
                deckNumber1.Text = "Baralho #1 (" + deck1.Count +" cartas) "; 
            }
            else
            {
                txtDeck2.Items.Clear();
                foreach (string cardName in deck2.GetCardNames())
                    txtDeck2.Items.Add(cardName);
                deckNumber2.Text = "Baralho #2 (" + deck2.Count + " cartas) ";
            }
        }

        private void resetDeck1_Click(object sender, EventArgs e)
        {
            ResetDeck(EDeck.Deck1);
            RedrawDeck(EDeck.Deck1);
        }

        private void resetDeck2_Click(object sender, EventArgs e)
        {
            ResetDeck(EDeck.Deck2);
            RedrawDeck(EDeck.Deck2);
        }

        private void shuffleDeck1_Click(object sender, EventArgs e)
        {
            deck1.Shuffle();
            RedrawDeck(EDeck.Deck1);
        }

        private void shuffleDeck2_Click(object sender, EventArgs e)
        {
            deck2.Shuffle();
            RedrawDeck(EDeck.Deck2);
        }

        private void moveToDeck1_Click(object sender, EventArgs e)
        {
            if (txtDeck2.SelectedIndex >= 0)
                if (deck2.Count > 0)
                    deck1.Add(deck2.Deal(txtDeck2.SelectedIndex));
            RedrawDeck(EDeck.Deck1);
            RedrawDeck(EDeck.Deck2);
        }

        private void moveToDeck2_Click(object sender, EventArgs e)
        {
            if (txtDeck1.SelectedIndex >= 0)
                if (deck1.Count > 0)
                    deck2.Add(deck1.Deal(txtDeck1.SelectedIndex));
            RedrawDeck(EDeck.Deck1);
            RedrawDeck(EDeck.Deck2);
        }
    }

}
