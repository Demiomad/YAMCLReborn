using System;
using System.Collections.Generic;
using System.Text;
using YAMCLReborn.Core.Config;

namespace YAMCLReborn.Core
{
    /// <summary>
    /// Global paths for the program.
    /// </summary>
    public static class Paths
    {
        #region Directories

        /// <summary>
        /// The path where the program stores all its information.
        /// </summary>
        public static string ProgramPath { get; }
            = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "YAMCL Reborn");

        /// <summary>
        /// The path where YAMCL stores all its instances.
        /// </summary>
        public static string InstancesPath
            => Path.Combine(ProgramPath, "instances");

        /// <summary>
        /// The path where YAMCL stores all its logs.
        /// </summary>
        public static string LogsPath
            => Path.Combine(ProgramPath, "logs");

        #endregion

        #region Files

        /// <summary>
        /// The file where YAMCL stores its configuration.
        /// </summary>
        public static string ConfigFile 
            => Path.Combine(ProgramPath, "config.json");

        /// <summary>
        /// The OOBE marker file.
        /// </summary>
        public static string OobeMarkerFile
            => Path.Combine(ProgramPath, "oobe");

        /// <summary>
        /// Gets the current log file name.
        /// </summary>
        public static string GetLogFileName()
        {
            var now = DateTime.Now;
            var fileName = $"YAMCL-{now:ddMMyyyy}.log";
            return fileName;
        }

        /// <summary>
        /// Gets the current log file's path.
        /// </summary>
        public static string GetLogFilePath()
            => Path.Combine(LogsPath, GetLogFileName());

        #endregion
    }
}
