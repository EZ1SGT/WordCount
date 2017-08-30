using System;
using System.Collections.Generic;
using NUnit.Framework;
using WordCount;

namespace WordCountTests.WordCounterTests
{
    [TestFixture]
    public class SplitIntoWordsTests
    {
        [Test]
        public void StringMitZweiWörter_ListeMitZweiWörtern()
        {
            var erwartet = new List<String>() { "Test", "Welt" };
            Assert.That(WordCounter.SplitIntoWords("Test Welt"), Is.EqualTo(erwartet));
        }

        [Test]
        public void StringMitZweiWörterDieDurchEinenStrichGetrenntSind_ListeMitEinemWort()
        {
            var erwartet = new List<String>() { "Test-Welt" };
            Assert.That(WordCounter.SplitIntoWords("Test-Welt"), Is.EqualTo(erwartet));
        }

        [Test]
        public void StringMitEinemWortUndEinerZahl_ListeMitEinemWort()
        {
            var erwartet = new List<String>() { "Test" };
            Assert.That(WordCounter.SplitIntoWords("Test 123"), Is.EqualTo(erwartet));
        }
    }
}