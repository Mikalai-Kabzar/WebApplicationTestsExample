using System;
using log4net;
using log4net.Config;

namespace Framework.Tools.Logger
{
    public class Logger : ILogger
    {
        private ILog _logger;

        public static void Init()
        {
            XmlConfigurator.Configure();
        }

        public Logger(Type type)
        {
            _logger = LogManager.GetLogger(type);
        }

        public void Info(string message)
        {
            _logger.Info(message);
        }

        public void Debug(string message)
        {
            _logger.Debug(message);
        }

        public void Warn(string message)
        {
            _logger.Warn(message);
        }

        public void Error(string message)
        {
            _logger.Info(message);
        }
    }
}
