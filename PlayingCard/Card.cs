namespace PlayingCard
{
    public readonly struct Card
    {
        public Card(Ranks rank, Suits suit)
        {
            Rank = rank;
            Suit = suit;
        }

        public Ranks Rank { get; }
        public Suits Suit { get; }

        public override string ToString()
        {
            return $"Card[Rank = {Rank}, Suit = {Suit}]";
        }
    }
}