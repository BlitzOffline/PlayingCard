using System;

namespace PlayingCard
{
    internal class Program
    {
        public static void Main()
        {
            var deck = new CardDeck();
            deck.Shuffle();
            Console.WriteLine(deck);
        }
    }
}