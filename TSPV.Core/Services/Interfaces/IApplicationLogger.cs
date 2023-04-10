namespace TSPV.Core.Services.Interfaces
{
    using System;
    using NLog;

    public interface IApplicationLogger
    {
        void Log(LogLevel level, string message);
        void LogException(LogLevel level, Exception ex);
        void LogException(LogLevel level, Exception ex, string message);
    }
}