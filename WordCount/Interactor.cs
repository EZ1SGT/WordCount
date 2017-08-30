namespace WordCount
{
    public static class Interactor
    {
        public static void CountWords(string filename = null)
        {
            var text = TextProvider.GetText(filename);
            var words = WordCounter.SplitIntoWords(text);
            var stopwords = StopwordsProvider.GetStopwords();
            words = WordCounter.RemoveStopwords(words, stopwords);
            var count = WordCounter.CountWordsInList(words);
            var uniqueCount = WordCounter.CountUniqueWords(words);
            var averageWordLenght = WordCounter.GetAverageWordLength(words);
            ConsoleUI.PrintCount(count, uniqueCount, averageWordLenght);
            if (Commandline.HasDictionaryOption())
            {
                WordCounter.SetDictionary(DictionaryProvider.GetDictionary(Commandline.GetDictionaryFilename()));
            }
            if (Commandline.HasIndexOption())
            {
                ConsoleUI.PrintWordIndex(words);
            }
        }
    }
}
