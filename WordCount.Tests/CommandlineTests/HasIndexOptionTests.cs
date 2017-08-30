using NUnit.Framework;
using WordCount;

namespace WordCountTests.CommandlineTests
{
    [TestFixture]
    public class HasIndexOptionTests
    {
        [Test]
        public void ListeMitZweiOptionen_True()
        {
            Commandline.SetArguments(new []{"-index", "test"});
            Assert.That(Commandline.HasIndexOption, Is.EqualTo(true));
        }

        [Test]
        public void ListeMitZweiOptionen_False()
        {
            Commandline.SetArguments(new[] { "index", "test" });
            Assert.That(Commandline.HasIndexOption, Is.EqualTo(false));
        }
    }
}