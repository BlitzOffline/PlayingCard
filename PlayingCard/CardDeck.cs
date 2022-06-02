using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayingCard
{
    public class CardDeck
    {
        private Queue<Card> _cards = new Queue<Card>();

        public CardDeck()
        {
            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                foreach (Ranks rank in Enum.GetValues(typeof(Ranks)))
                {
                    AddCard(new Card(rank, suit));
                }
            }
        }

        public int Count()
        {
            return _cards.Count;
        }

        public void AddCard(Card card)
        {
            _cards.Enqueue(card);
        }

        public Card DrawCard()
        {
            if (_cards.Count == 0) throw new InvalidOperationException("No more cards in the deck.");
            return _cards.Dequeue();
        }

        public void Shuffle()
        {
            _cards = new Queue<Card>(Shuffle(_cards.ToList()));
        }
        
        private static List<T> Shuffle<T>(List<T> list)  
        {
            var random = new Random();

            for(var i= list.Count - 1; i > 1; i--)
            {
                var rnd = random.Next(i + 1);  

                (list[rnd], list[i]) = (list[i], list[rnd]);
            }

            return list;
        }

        public override string ToString()
        {
            return $"Deck{{{string.Join(", ", _cards)}}}";
        }
    }
}