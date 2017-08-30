using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text.RegularExpressions;

namespace WordCount
{
    public static class WordCounter
    {
        private static List<String> _dictionary;

        public static List<String> SplitIntoWords(String text)
        {
            var regex = new Regex("[^a-zA-Z/-]");
            var words = regex.Split(text).ToList();
            return RemoveEmptyStrings(words);
        }

        public static List<String> RemoveEmptyStrings(List<String> words)
        {
            return (from word in words where !string.IsNullOrEmpty(word) select word).ToList();
        }

        public static List<String> RemoveStopwords(List<String> words, List<String> stopwords)
        {
            return (from word in words where !stopwords.Contains(word) select word).ToList();
        }

        public static int CountUniqueWords(List<String> words)
        {
            return words.Distinct().Count();
        }

        public static double GetAverageWordLength(List<String> words)
        {
            return words.Average(item => item.Length);
        }

        public static int CountWordsInList(List<String> words)
        {
            return words.Count;
        }

        public static bool ContainedInDictionary(String word)
        {
            return _dictionary.Contains(word);
        }

        public static int CountWordsNotInDictionary(List<string> words)
        {
            return (from word in words where !_dictionary.Contains(word) select word).Count();
        }

        public static bool HasDictionary()
        {
            return _dictionary != null;
        }

        public static void SetDictionary(List<String> dictionary)
        {
            _dictionary = dictionary;
        }
    }
}
