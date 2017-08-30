using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    public class DictionaryProvider
    {
        public static List<String> GetDictionary(String filename)
        {
            return File.ReadAllLines(filename).ToList();
        }
    }
}