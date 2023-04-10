namespace TSPV.Core.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NLog;
    using TSPV.Core.Services.Interfaces;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    public class ApplicationLogger : IApplicationLogger
    {
        private static readonly Logger _defaultLogger = LogManager.GetLogger("DefaultLogger");
        private static readonly Logger _defaultCsvLogger = LogManager.GetLogger("DefaultCsvLogger");

        public void Log(LogLevel level, string message) => _defaultLogger.Log(typeof(ApplicationLogger), new LogEventInfo(level, "DefaultLogger", message));

        public void LogException(LogLevel level, Exception ex)
        {
            LogEventInfo logEvent = new LogEventInfo(level, "DefaultCsvLogger", ex.Message);
            logEvent.Exception = ex;
            _defaultCsvLogger.Log(typeof(ApplicationLogger), logEvent);
        }

        public void LogException(LogLevel level, Exception ex, string message)
        {
            LogEventInfo logEvent = new LogEventInfo(level, "DefaultCsvLogger", message);
            logEvent.Exception = ex;
            _defaultCsvLogger.Log(typeof(ApplicationLogger), logEvent);
        }
    }
}
}
