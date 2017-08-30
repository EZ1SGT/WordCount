using System;
using System.Collections.Generic;
using NUnit.Framework;
using WordCount;

namespace WordCountTests.WordCounterTests
{
    [TestFixture]
    public class CountWordsInListTests
    {
        [Test]
        public void ListeMitZweiStrings_Zwei()
        {
            var gegeben = new List<String>() {"Test", "Test"};
            Assert.That(WordCounter.CountWordsInList(gegeben), Is.EqualTo(2));
        }
    }
}