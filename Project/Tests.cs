using System;
using System.Linq;
using NUnit.Framework;

namespace MindoxTesting
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void ShouldSortCards()
        {
            var expected = string.Join(",", 
                CardSamples.GetSortedSamples().Select(s => s.ToString()));
            var samples = CardSamples.GetMixedSamples();
            var sorted = Program.GetSortedCards(samples);
            var actual = string.Join(",", sorted.Select(s => s.ToString()));
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ShouldThrowExceptionOnEmptyCards()
        {
            var samples = CardSamples.GetEmptySamples();
            Assert.Throws<Exception>(() =>
            {
                var actual = Program.GetSortedCards(samples);
            });
        }

        [Test]
        public void ShouldThrowExceptionOnNullCards()
        {
            var samples = CardSamples.GetNullSample();
            Assert.Throws<Exception>(() =>
            {
                var actual = Program.GetSortedCards(samples);
            });
        }

        [Test]
        public void ShouldThrowExceptionOnCycledCards()
        {
            var samples = CardSamples.GetCycledSamples();
            Assert.Throws<Exception>(() =>
            {
                var actual = Program.GetSortedCards(samples);
            });
        }

        [Test]
        public void ShouldThrowExceptionOnWrongCards()
        {
            var samples = CardSamples.GetWrongSamples();
            Assert.Throws<Exception>(() =>
            {
                var actual = Program.GetSortedCards(samples);
            });
        }
    }
}