using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EFLogging.GeneralCalsses
{
    class LoggerProvider: ILoggerProvider
    {
        public ILogger CreateLogger(string CatName)
        {
            return new LoggerTest();
        }

        public void Dispose() { }

    }

    internal class LoggerTest : ILogger
    {
        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId,
                TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            File.AppendAllText("log.txt", formatter(state, exception));
            Console.WriteLine(formatter(state, exception));
        }
    }
}
