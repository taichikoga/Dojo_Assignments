using System;
using System.Collections.Generic;

namespace Assignment_Deck_of_Cards
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Hand { get; set; }

        public Player(string name)
        {
            Name = name;
            Hand = new List<Card>();
        }

        public Card Draw(Deck cards)
        {
            // draws a card from a deck & adds the card to the player's hand
            Hand.Add(cards.Deal());
            // returns the card
            return Hand[Hand.Count-1];
        }

        public Card Discard(int index)
        {
            dynamic temp = Hand[index];
            Hand.RemoveAt(index);
            return temp;
        }
    }
}