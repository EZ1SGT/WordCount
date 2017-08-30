using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    public static class StopwordsProvider
    {
        public static List<String> GetStopwords()
        {
            var filename = "stopwords.txt";
            return File.ReadLines(filename).ToList();
        }
    }
}
