namespace MindoxTesting
{
    public class Card
    {
        public string Source { get; set; }

        public string Destination { get; set; }

        public override string ToString()
        {
            return Source + "->" + Destination;
        }

        public static Card[] GetMixedSamples()
        {
            return new[]
            {
                new Card {Source = "Melbourne", Destination = "Koln"},
                new Card {Source = "Moscow", Destination = "Paris"},
                new Card {Source = "Koln", Destination = "Moscow"}
            };
        }

        public static Card[] GetEmptySamples()
        {
            return new Card[]{};
        }

        public static Card[] GetNullSample()
        {
            return null;
        }
    }
}