using System;
using System.Collections.Generic;
using NUnit.Framework;
using WordCount;

namespace WordCountTests.WordCounterTests
{
    [TestFixture]
    public class CountUniqueWordsTests
    {
        [Test]
        public void ListeMitZweiGleichenStrings_Eins()
        {
            var gegeben = new List<String>() {"Test", "Test"};
            Assert.That(WordCounter.CountUniqueWords(gegeben), Is.EqualTo(1));
        }
    }
}