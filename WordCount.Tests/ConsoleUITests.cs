using System.Collections.Generic;
using NUnit.Framework;
using WordCount;

namespace WordCountTests
{
    [TestFixture()]
    public class ConsoleUITests
    {
        [Test()]
        public void PrintCountTest()
        {
            using (var consoleOutput = new ConsoleOutput())
            {
                ConsoleUI.PrintCount(5, 3, 2.233);
                Assert.That(consoleOutput.ConsoleOut[0], Is.EqualTo("Number of words: 5, unique: 3; average word length: 2,23 characters"));
            }
        }

        [Test()]
        public void PrintWordIndexTest()
        {
            using (var consoleOutput = new ConsoleOutput())
            {
                ConsoleUI.PrintWordIndex(new List<string>() {"Hallo", "Welt", "Apfel"});
                Assert.That(consoleOutput.ConsoleOut, Is.EqualTo(new []
                {
                    "Index:",
                    "Apfel",
                    "Hallo",
                    "Welt",
                    ""
                }));
            }
        }
    }
}