using System;
using System.Collections.Generic;
using NUnit.Framework;
using WordCount;

namespace WordCountTests.WordCounterTests
{
    [TestFixture]
    public class RemoveStopwordsTests
    {
        [Test]
        public void ListeMitZweiWörtern_ListeMitEinemWort()
        {
            var gegeben = new List<String>() {"Hallo", "Welt"};
            var stopwords = new List<String>() {"Welt"};
            var erwartet = new List<String>() {"Hallo"};
            Assert.That(WordCounter.RemoveStopwords(gegeben,stopwords), Is.EqualTo(erwartet));
        }

        [Test]
        public void ListeMitVierWörternDavonJeZweiGleich_ListeMitZweiWörtern()
        {
            var gegeben = new List<String>() { "Hallo", "Welt", "Hallo", "Welt" };
            var stopwords = new List<String>() { "Welt" };
            var erwartet = new List<String>() { "Hallo", "Hallo" };
            Assert.That(WordCounter.RemoveStopwords(gegeben, stopwords), Is.EqualTo(erwartet));
        }
    }
}