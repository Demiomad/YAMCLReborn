using System;
using System.Collections.Generic;
using System.Text;
using YAMCLReborn.Core.Config;

namespace YAMCLReborn.Core.Logging
{
    /// <summary>
    /// Represents a logger.
    /// </summary>
    public static class Logger
    {
        private static readonly string _logFile = Paths.GetLogFilePath();

        private static void LogWithoutFile(LogLevel level, string message)
        {
            if (!ConfigManager.CurrentConfig.ShowDebugWindow)
                return; // Console isn't allocated yet

            Console.ForegroundColor = level.Color;
            var prefix = $"[ {DateTime.Now:HH:mm:ss} - {level.Prefix} ] ";
            Console.Write(prefix);
            Console.ResetColor();
            Console.WriteLine(message);
        }

        /// <summary>
        /// Logs a message to the logger.
        /// </summary>
        /// <param name="level">The log level, in other words, the severity of the message.</param>
        /// <param name="message">The message.</param>
        public static void Log(LogLevel level, string message)
        {
            if (!ConfigManager.CurrentConfig.ShowDebugWindow)
                return; // Console isn't allocated yet

            var prefix = $"[ {DateTime.Now:HH:mm:ss} - {level.Prefix} ] ";
            LogWithoutFile(level, message);

            if (ConfigManager.CurrentConfig.LogToFile)
            {
                try
                {
                    File.AppendAllText(_logFile, $"{prefix}{message}\n");
                }
                catch (Exception ex)
                {
                    LogWithoutFile(LogLevel.Error, ex.Message);
                }
            }
        }
    }
}
