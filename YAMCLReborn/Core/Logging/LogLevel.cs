using System;
using System.Collections.Generic;
using System.Text;

namespace YAMCLReborn.Core.Logging
{
    /// <summary>
    /// Represents a log level.
    /// </summary>
    public class LogLevel
    {
        public static readonly LogLevel Info = new("INF", ConsoleColor.Cyan);
        public static readonly LogLevel Warn = new("WRN", ConsoleColor.Yellow);
        public static readonly LogLevel Error = new("ERR", ConsoleColor.Red);
        public static readonly LogLevel Fatal = new("FTL", ConsoleColor.DarkRed);

        /// <summary>
        /// The prefix of the log.
        /// </summary>
        public string? Prefix { get; set; }

        /// <summary>
        /// The prefix's color.
        /// </summary>
        public ConsoleColor Color { get; set; }

        public LogLevel(string pref, ConsoleColor col)
        {
            Prefix = pref;
            Color = col;
        }
    }
}
