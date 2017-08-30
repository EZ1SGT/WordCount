using System;
using System.IO;

namespace WordCountTests
{
    class ConsoleOutput : IDisposable
    {
        private readonly StringWriter _newConsoleOut;
        private readonly TextWriter _originalConsoleOut;

        public ConsoleOutput()
        {
            _newConsoleOut = new StringWriter();
            _originalConsoleOut = Console.Out;
            Console.SetOut(_newConsoleOut);
        }

        public string[] ConsoleOut => _newConsoleOut
            .ToString()
            .Split(new[] {Environment.NewLine}, StringSplitOptions.None);

        public void Dispose()
        {
            Console.SetOut(_originalConsoleOut);
            _newConsoleOut.Dispose();
        }

    }
}
