using System;
using System.Collections.Generic;

namespace Assignment_Deck_of_Cards
{
    public class Deck
    {
        public List<Card> cards { get; set; }

        public Deck()
        {
            cards = new List<Card>();
            string[] stringVal = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
            string[] suit = {"Clubs", "Spades", "Hearts", "Diamonds"};
            int[] val = {1,2,3,4,5,6,7,8,9,10,11,12,13};
            for (int name = 0; name <= 12; name++)
            {
                for (int suits = 0; suits <= 3; suits++)
                {
                    cards.Add(new Card()
                    {
                        stringVal = stringVal[name],
                        suit = suit[suits],
                        val = val[name]
                    });
                }
            }
            // foreach (dynamic card in cards)
            // {
            //     Console.WriteLine($"{card.stringVal} of {card.suit}, {card.val}");
            // }
            // Console.WriteLine(cards.Count);
        }

        public Card Deal()
        {
            // Console.WriteLine($"Dealing {cards[0].stringVal} of {cards[0].suit}");
            cards.RemoveAt(0);
            return cards[0];
        }

        public void Reset()
        {
            // Console.WriteLine(cards.Count);
            cards = new List<Card>();
            string[] stringVal = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
            string[] suit = {"Clubs", "Spades", "Hearts", "Diamonds"};
            int[] val = {1,2,3,4,5,6,7,8,9,10,11,12,13};
            for (int name = 0; name <= 12; name++)
            {
                for (int suits = 0; suits <= 3; suits++)
                {
                    cards.Add(new Card()
                    {
                        stringVal = stringVal[name],
                        suit = suit[suits],
                        val = val[name]
                    });
                }
            }
            // Console.WriteLine(cards.Count);
        }
    }
}