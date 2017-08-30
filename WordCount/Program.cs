using System;

namespace WordCount
{
    static class Program
    {
        static void Main(String[] args)
        {
            Commandline.SetArguments(args);
            Interactor.CountWords(Commandline.ExtractFilename());
            Console.ReadKey();
        }
    }
}
