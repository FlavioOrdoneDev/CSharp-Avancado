using Go_Fish_Dictionary.enums;
using System;
using System.Collections.Generic;

namespace Go_Fish_Dictionary.entities
{
    public class Deck
    {
        private List<Card> cards;

        private Random random = new Random();

        public Deck()
        {
            cards = GetCardsFull();
        }

        public Deck(IEnumerable<Card> initialCards)
        {
            cards = new List<Card>(initialCards);
        }

        public int Count { get { return cards.Count; } }

        public void Add(Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }

        public Card Deal()
        {
            return Deal(0);
        }

        public Card Deal(int index)
        {
            Card cardToDeal = cards[index];
            cards.RemoveAt(index);

            return cardToDeal;
        }

        public void Shuffle()
        {
            List<Card> NewCards = new List<Card>();
            while (cards.Count > 0)
            {
                int CardToMove = random.Next(cards.Count);
                NewCards.Add(cards[CardToMove]);
                cards.RemoveAt(CardToMove);
            }
            cards = NewCards;
        }

        public IEnumerable<string> GetCardNames()
        {
            string[] CardNames = new string[cards.Count];
            for (int i = 0; i < cards.Count; i++)
                CardNames[i] = cards[i].Name;
            return CardNames;
        }

        public void Sort()
        {
            cards.Sort(new CardComparerBySuit());
        }

        private List<Card> GetCardsFull()
        {
            var cards =  new List<Card>();

            for (int suit = 0; suit <= 3; suit++)
                for (int value = 1; value <= 13; value++)
                    cards.Add(new Card((Suit)suit, (Value)value));

            return cards;
        }

        public Card Peek(int cardNumber)
        {
            return cards[cardNumber];
        }

        public bool ContainsValues(Value value)
        {
            foreach (Card card in cards)
            {
                if (card.Values == value)
                    return true;                
            }

            return false;
        }

        public Deck PullOutValues(Value value)
        {
            Deck deckToReturn = new Deck(new Card[] { });
            for (int i = cards.Count -1; i >= 0; i--)
            {
                if (cards[i].Values == value)
                {
                    deckToReturn.Add(Deal(i));
                }
            }

            return deckToReturn;
        }

        public bool HasBook(Value value)
        {
            int numberOfCards = 0;
            foreach (Card card in cards)
            {
                if (card.Values == value)
                    numberOfCards++;
            }

            if (numberOfCards == 4)
                return true;
            else
                return false;
        }

        public void SortByValue()
        {
            cards.Sort(new CardComparerByValue());
        }
    }
}
