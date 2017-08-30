using NUnit.Framework;
using WordCount;

namespace WordCountTests.CommandlineTests
{
    [TestFixture]
    public class GetDictionaryFilenameTests
    {
        [Test]
        public void ListeMitZweiOptionen_Filename()
        {
            Commandline.SetArguments(new []{"-index", "-dictionary=test.txt"});
            Assert.That(Commandline.GetDictionaryFilename(), Is.EqualTo("test.txt"));
        }
    }
}