using System;
using System.Collections.Generic;

namespace MindoxTesting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cards = Card.GetMixedSamples();
            var sortedCards = GetSortedCards(cards);
            foreach (var card in sortedCards)
            {
                Console.WriteLine(card.ToString());
            }
            Console.ReadKey();
        }

        public static IEnumerable<Card> GetSortedCards(Card[] cards)
        {
            var result = new List<Card>();
            var sourceDictionary = new Dictionary<string, Card>();
            var destinationDictionary = new Dictionary<string, Card>();

            for (int i = 0; i < cards.Length; i++) // Filling dictionaries
            {
                var buffer = cards[i];
                sourceDictionary.Add(buffer.Source,buffer);
                destinationDictionary.Add(buffer.Destination, buffer);
            }

            for (int i = 0; i < cards.Length; i++) // Looking for the first element
            {
                var buffer = cards[i];
                if (!destinationDictionary.ContainsKey(buffer.Source))
                {
                    result.Add(buffer);
                    break;
                }
            }

            var current = result[0];
            while (result.Count != cards.Length) // Sorting array
            {
                current = sourceDictionary[current.Destination];
                result.Add(current);
            }

            return result;
        } 
    }
}
