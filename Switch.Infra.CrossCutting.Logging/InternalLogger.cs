using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch.Infra.CrossCutting.Logging
{
    internal class InternalLogger : ILogger
    {
        private bool Enabled => true;

        public IDisposable BeginScope<TState>(TState state)
        {
            throw new NotImplementedException();
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return Enabled;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            //File.AppendAllText(@"C:\Users\evert\source\repos\Switch\InternalLogger\Logs\log.txt", 
            //    formatter(state, exception));
            
            Console.WriteLine(formatter(state, exception));
        }
    }
}
