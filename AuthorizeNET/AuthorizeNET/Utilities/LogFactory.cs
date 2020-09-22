namespace AuthorizeNet.Utilities
{
    using System;
    using Microsoft.Extensions.Logging;

    public static class LogFactory
    {
#if false
        private static ILoggerFactory LoggerFactory => new LoggerFactory().AddDebug(LogLevel.Debug);
#else
        private static ILoggerFactory LoggerFactory => new LoggerFactory(); // Removed due to problem when used with an Blazor web application.
#endif

        public static ILogger getLog(Type classType)
        {
            return LoggerFactory.CreateLogger(classType.FullName);
        }
    }
}