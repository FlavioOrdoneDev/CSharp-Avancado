using Go_Fish_Dictionary.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace Go_Fish_Dictionary.entities
{
    public class Game
    {
        private List<Player> players;
        private Dictionary<Value, Player> books;
        private Deck stock;
        private TextBox textBoxOnForm;

        public Game(string name, IEnumerable<string> oponentNames, TextBox textBoxOnForm)
        {
            Random random = new Random();
            this.textBoxOnForm = textBoxOnForm;
            players = new List<Player>();
            players.Add(new Player(name, random, textBoxOnForm));
            foreach (string player in oponentNames)
                players.Add(new Player(player, random, textBoxOnForm));
            books = new Dictionary<Value, Player>();
            stock = new Deck();
            Deal();
            players[0].SortHand();
        }

        private void Deal()
        {
            stock.Shuffle();
            for (int i = 0; i < 5; i++)
            {
                foreach (Player player in players)
                {
                    player.TakeCard(stock.Deal());
                }
            }
            foreach (Player player in players)
            {
                PullOutBooks(player);
            }
        }

        public IEnumerable<string> GetPlayerCardNames()
        {
            return players[0].GetCardNames();
        }

        public string DescribeBooks()
        {
            string whoHasWichBooks = "";
            foreach (Value value in books.Keys)
            {
                whoHasWichBooks += books[value].Name + " has a book of " + Card.Plural(value) + Environment.NewLine;
            }

            return whoHasWichBooks;
        }
        
        public string DescribePlayerHands()
        {
            string desciption = "";
            for (int i = 0; i < players.Count; i++)
            {
                desciption += players[i].Name + " has " + players[i].CardCount;
                if (players[i].CardCount == 1)
                    desciption += " card." + Environment.NewLine;
                else
                    desciption += " cards." + Environment.NewLine;
            }

            desciption += "The stock has " + stock.Count + " cards left.";
            return desciption;
        }

        public bool PlayOneRound(int selectedPlayerCard)
        {
            Value cardToAskFor = players[0].Peek(selectedPlayerCard).Values;
            for (int i = 0; i < players.Count; i++)
            {
                if (i == 0)
                    players[0].AskForACard(players, 0, stock, cardToAskFor);
                else
                    players[i].AskForACard(players, i, stock);
                if (PullOutBooks(players[i]))
                {
                    textBoxOnForm.Text += players[i].Name + " draw a new hand" + Environment.NewLine;
                    int card = i;
                    while (card <= 5 && stock.Count > 0)
                    {
                        players[i].TakeCard(stock.Deal());
                        card++;
                    }
                }

                players[0].SortHand();
                if (stock.Count == 0)
                {
                    textBoxOnForm.Text = "The stock is out of cards. Game over!" + Environment.NewLine;
                    return true;
                }
            }

            return false;
        }

        public bool PullOutBooks(Player player)
        {
            IEnumerable<Value> booksPulled = player.PullOutBooks();
            foreach (Value value in booksPulled)
            {
                books.Add(value, player);
            }
            if (player.CardCount == 0)
                return true;
            return false;
        }

        public string GetWinnerName()
        {
            Dictionary<string, int> winners = new Dictionary<string, int>();
            foreach (Value value in books.Keys)
            {
                string name = books[value].Name;
                if (winners.ContainsKey(name))
                    winners[name]++;
                else
                    winners.Add(name, 1);
            }
            int mostBooks = 0;
            foreach (string name in winners.Keys)
            {
                if (winners[name] > mostBooks)
                    mostBooks = winners[name];
            }
            bool tie = false;
            string winnerList = "";
            foreach (string name in winners.Keys)
            {
                if (winners[name] == mostBooks)
                {
                    if (!String.IsNullOrEmpty(winnerList))
                    {
                        winnerList += " and ";
                        tie = true;
                    }
                    winnerList += name;
                }
            }
            winnerList += " with " + mostBooks + " books";
            if (tie)
                return "A tie between " + winnerList;
            else
                return winnerList;            
        }
    }
}
