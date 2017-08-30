using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCount
{
    public static class ConsoleUI
    {
        public static String ReadText()
        {
            return Console.ReadLine();
        }

        public static void PrintCount(int count, int uniqueCount, double averageWordLength)
        {
            Console.WriteLine("Number of words: {0}, unique: {1}; average word length: {2:F} characters" , count, uniqueCount, averageWordLength);
        }

        public static void PrintWordIndex(List<string> words)
        {
            Console.WriteLine("Index" + (WordCounter.HasDictionary() ? " (unknown: " + WordCounter.CountWordsNotInDictionary(words) + ")" : "") + ":");
            foreach (var word in words.OrderBy(x=>x).ToList())
            {
                Console.WriteLine(word + (WordCounter.HasDictionary() && !WordCounter.ContainedInDictionary(word) ? "*" : ""));
            }
        }
    }
}
