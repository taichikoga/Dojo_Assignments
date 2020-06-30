using System;
using System.Collections.Generic;

namespace Assignment_Deck_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck cards = new Deck();
            cards.Deal();
            cards.Reset();
            Player player1 = new Player("Michael");
            Console.WriteLine(player1.Name);
            // player1.Draw(cards);
            Console.WriteLine(player1.Draw(cards).stringVal);
            System.Console.WriteLine(player1.Discard(0).stringVal);
        }
    }
}
