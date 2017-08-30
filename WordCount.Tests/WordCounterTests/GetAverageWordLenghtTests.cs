using System;
using System.Collections.Generic;
using NUnit.Framework;
using WordCount;

namespace WordCountTests.WordCounterTests
{
    [TestFixture]
    public class GetAverageWordLenghtTests
    {
        [Test]
        public void ListeMitZweiWörtern_Zwei()
        {
            var gegeben = new List<String>() {"mit", "I"};
            Assert.That(WordCounter.GetAverageWordLength(gegeben), Is.EqualTo(2));
        }

        [Test]
        public void ListeMitFünfWörtern_Fier()
        {
            var gegeben = new List<String>() { "Baum", "Haus", "mit", "bauen" };
            Assert.That(WordCounter.GetAverageWordLength(gegeben), Is.EqualTo(4));
        }
    }
}