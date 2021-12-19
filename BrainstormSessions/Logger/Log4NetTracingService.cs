namespace BrainstormSessions.Logger
{
    using log4net;
    using Microsoft.Extensions.Logging.Log4Net.AspNetCore.Extensions;
    using System;

    public class Log4NetTracingService
    {
        private readonly ILog _logger;

        public Log4NetTracingService(string name)
        {
            _logger = LogManager.GetLogger(name);
        }

        public static Log4NetTracingService GetLogger(string name)
        {
            return new Log4NetTracingService(name);
        }

        public void Trace(string message, Exception exception)
        {
            _logger.Trace(message, exception);
        }

        public void Info(string message)
        {
            _logger.Info(message);
        }

        public void Debug(string message)
        {
            _logger.Debug(message);
        }
        public void Error(string message)
        {
            _logger.Error(message);
        }

        public void Error(Exception exception)
        {
            _logger.Error(exception);
        }

        public void Error(Exception exception, string message)
        {
            _logger.Error(message, exception);
        }

        public void Warn(string message)
        {
            _logger.Warn(message);
        }
    }
}
