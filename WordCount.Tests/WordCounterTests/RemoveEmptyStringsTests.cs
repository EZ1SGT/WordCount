using System;
using System.Collections.Generic;
using NUnit.Framework;
using WordCount;

namespace WordCountTests.WordCounterTests
{
    [TestFixture]
    class RemoveEmptyStringsTests
    {
        [Test]
        public void ListeMitZweiStringsEinerDavonLeer_ListeMitEinemStrings()
        {
            var gegeben = new List<String>() {"Test", ""};
            var erwartet = new List<String>() {"Test"};
            Assert.That(WordCounter.RemoveEmptyStrings(gegeben), Is.EqualTo(erwartet));
        }

        [Test]
        public void ListeMitDreiStringsZweiDavonLeer_ListeMitEinemStrings()
        {
            var gegeben = new List<String>() { "Test", "", "" };
            var erwartet = new List<String>() { "Test" };
            Assert.That(WordCounter.RemoveEmptyStrings(gegeben), Is.EqualTo(erwartet));
        }

        [Test]
        public void ListeMitDreiStringsEinerDavonLeer_ListeMitZweiStrings()
        {
            var gegeben = new List<String>() { "Test", "", "Welt" };
            var erwartet = new List<String>() { "Test", "Welt" };
            Assert.That(WordCounter.RemoveEmptyStrings(gegeben), Is.EqualTo(erwartet));
        }
    }
}