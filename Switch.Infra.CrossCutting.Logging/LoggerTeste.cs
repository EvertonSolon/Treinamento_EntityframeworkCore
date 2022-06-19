using Microsoft.Extensions.Logging;

namespace Switch.Infra.CrossCutting.Logging
{
    public class Logger : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName)
        {
            return new InternalLogger();
        }

        public void Dispose()
        {
            
        }
    }
}