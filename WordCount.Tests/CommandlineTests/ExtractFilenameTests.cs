using NUnit.Framework;
using WordCount;

namespace WordCountTests.CommandlineTests
{
    [TestFixture]
    public class ExtractFilenameTests
    {
        [Test]
        public void ArrayMitZweiStringsEinerDavonOption_Filename()
        {
            var gegeben =new[] {"test.txt", "-index"};
            Commandline.SetArguments(gegeben);
            Assert.That(Commandline.ExtractFilename(), Is.EqualTo("test.txt"));
        }

        [Test]
        public void ArrayMitZweiStringsZweiDavonOption_Null()
        {
            var gegeben = new[] { "-help", "-index" };
            Commandline.SetArguments(gegeben);
            Assert.That(Commandline.ExtractFilename(), Is.Null);
        }

        [Test]
        public void ArrayMitNullStrings_Null()
        {
            var gegeben = new string[] {};
            Commandline.SetArguments(gegeben);
            Assert.That(Commandline.ExtractFilename(), Is.Null);
        }
    }
}