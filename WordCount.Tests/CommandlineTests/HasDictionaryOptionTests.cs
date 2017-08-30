using System;
using System.Collections.Generic;
using NUnit.Framework;
using WordCount;

namespace WordCountTests.CommandlineTests
{
    [TestFixture]
    public class HasDictionaryOptionTests
    {
        [Test]
        public void ListeMitZweiOptionen_True()
        {
            Commandline.SetArguments(new []{"-index", "-dictionary=test"});
            Assert.That(Commandline.HasDictionaryOption, Is.EqualTo(true));
        }

        [Test]
        public void ListeMitZweiOptionen_False()
        {
            Commandline.SetArguments(new[] { "-index", "-dictionary" });
            Assert.That(Commandline.HasDictionaryOption, Is.EqualTo(false));
        }
    }
}