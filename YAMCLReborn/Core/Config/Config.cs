using System;
using System.Collections.Generic;
using System.Text;

namespace YAMCLReborn.Core.Config
{
    /// <summary>
    /// Represents a configuration.
    /// </summary>
    public class Config
    {
        /// <summary>
        /// The path where the program's data gets stored.
        /// </summary>
        public string DataPath { get; set; } = Paths.ProgramPath;

        /// <summary>
        /// The path where Java is located.
        /// </summary>
        public string? JavaPath { get; set; }

        /// <summary>
        /// Whether to show the debug log window.
        /// </summary>
        public bool ShowDebugWindow { get; set; }

        /// <summary>
        /// Whether to log to a file.
        /// </summary>
        public bool LogToFile { get; set; } = true;
    }
}
