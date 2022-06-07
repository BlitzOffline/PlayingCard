namespace PlayingCard
{
    public readonly struct Card
    {
        public Card(Rank rank, Suit suit)
        {
            Rank = rank;
            Suit = suit;
        }

        public Rank Rank { get; }
        public Suit Suit { get; }

        public override string ToString()
        {
            return $"Card[Rank = {Rank}, Suit = {Suit}]";
        }
    }
}