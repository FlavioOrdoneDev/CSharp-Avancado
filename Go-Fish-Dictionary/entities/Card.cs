

using Go_Fish_Dictionary.enums;
using System.Collections.Generic;

namespace Go_Fish_Dictionary.entities
{
    public partial class Card : IComparer<Card>
    {

        public Card(Suit suit, Value value)
        {
            this.Suits = suit;
            this.Values = value;
        }

        public Suit Suits { get; set; }

        public Value Values { get; set; }

        public string Name { get { return "" + Values.ToString() + " de " + Suits.ToString(); } }

        public static bool DoesCardMatch(Card cardToCheck, Suit suit)
        {
            if (cardToCheck.Suits == suit)
                return true;
            else
                return false;
        }

        public static bool DoesCardMatch(Card cardToCheck, Value value)
        {
            if (cardToCheck.Values == value)
                return true;
            else
                return false;
        }

        public int Compare(Card x, Card y)
        {
            if (x.Suits > y.Suits)
                return 1;
            else if (x.Suits < y.Suits)
                return -1;
            else
            {
                if (x.Values > y.Values)
                    return 1;
                else if (x.Values < y.Values)
                    return -1;
                else
                    return 0;
            }
        }        
    }

    public partial class Card
    {
        public static string Plural(Value value)
        {
            if (value == Value.Seis)
                return "Sixes";
            else
                return value.ToString() + "s";
        }
    }
}


