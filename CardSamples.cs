namespace MindoxTesting
{
    public class CardSamples
    {
        public static Card[] GetMixedSamples()
        {
            return new[]
            {
                new Card {Source = "Melbourne", Destination = "Koln"},
                new Card {Source = "Moscow", Destination = "Paris"},
                new Card {Source = "Koln", Destination = "Moscow"},
                new Card {Source = "Paris", Destination = "Warsaw"}
            };
        }

        public static Card[] GetSortedSamples()
        {
            return new[]
            {
                new Card {Source = "Melbourne", Destination = "Koln"},
                new Card {Source = "Koln", Destination = "Moscow"},
                new Card {Source = "Moscow", Destination = "Paris"},
                new Card {Source = "Paris", Destination = "Warsaw"}
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

        public static Card[] GetWrongSamples()
        {
            return new[]
            {
                new Card {Source = "Melbourne", Destination = "Koln"},
                new Card {Source = "Moscow", Destination = "Paris"},
                new Card {Source = "Paris", Destination = "Warsaw"}
            };
        }

        public static Card[] GetCycledSamples()
        {
            return new[]
            {
                new Card {Source = "Melbourne", Destination = "Koln"},
                new Card {Source = "Moscow", Destination = "Melbourne"},
                new Card {Source = "Koln", Destination = "Moscow"}
            };
        }
    }
}