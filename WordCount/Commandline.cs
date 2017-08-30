using System;
using System.ComponentModel;
using System.Linq;

namespace WordCount
{
    public class Commandline
    {
        private static string[] _arguments;
        public static String ExtractFilename()
        {
            //Entfernt alle Optionen von den agumenten
            var argumente = from item in _arguments where !item.StartsWith("-") select item;
            return argumente.Any() ? _arguments[0] : null;
        }

        public static bool HasIndexOption()
        {
            return _arguments.Contains("-index");
        }

        public static bool HasDictionaryOption()
        {
            return _arguments.Any(x => x.StartsWith("-dictionary="));
        }

        public static String GetDictionaryFilename()
        {
            return _arguments.First(x => x.StartsWith("-dictionary=")).Substring(12);
        }

        public static void SetArguments(string[] args)
        {
            _arguments = args;
        }
    }
}
