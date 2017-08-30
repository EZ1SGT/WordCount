using System;
using System.IO;

namespace WordCount
{
    public static class TextProvider
    {
        public static String GetText(string filename)
        {
            return filename is null ? ConsoleUI.ReadText() : File.ReadAllText(filename).Replace(Environment.NewLine, " ");
        }
    }
}
