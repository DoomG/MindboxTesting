using System;
using System.Collections.Generic;
using System.Linq;

namespace MindoxTesting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("FUCK IT ALL TWICE");
            var cards = CardSamples.GetMixedSamples();
            var sortedCards = GetSortedCards(cards);
            foreach (var card in sortedCards)
            {
                Console.WriteLine(card.ToString());
            }
            Console.ReadKey();
        }

        public static IEnumerable<Card> GetSortedCards(Card[] cards)
        {
            if(cards == null || !cards.Any())
                throw new Exception("There are no cards!");

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

            var current = result.FirstOrDefault();

            if(current == null)
                throw new Exception("Can't find the first card!");

            try
            {
                while (result.Count != cards.Length) // Sorting array
                {
                    current = sourceDictionary[current.Destination];
                    result.Add(current);
                }
            }
            catch (KeyNotFoundException e)
            {
                throw new Exception("The cards chain is broken!");
            }

            return result;
        } 
    }
}
