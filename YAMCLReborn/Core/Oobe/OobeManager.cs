using System;
using System.Collections.Generic;
using System.Text;
using YAMCLReborn.Core.Logging;
using YAMCLReborn.UI.Oobe;

namespace YAMCLReborn.Core.Oobe
{
    /// <summary>
    /// Manages the current OOBE (Out-Of-Box Experience) state.
    /// </summary>
    public static class OobeManager
    {
        /// <summary>
        /// Whether the OOBE is complete.
        /// </summary>
        public static bool IsComplete => File.Exists(Paths.OobeMarkerFile);

        /// <summary>
        /// Marks the OOBE as complete.
        /// </summary>
        public static void MarkComplete()
        {
            if (IsComplete)
                return;

            File.WriteAllText(Paths.OobeMarkerFile, DateTimeOffset.Now.ToUnixTimeSeconds().ToString());
        }

        /// <summary>
        /// Shows the OOBE.
        /// </summary>
        /// <param name="force">Whether to force the OOBE to appear.</param>
        public static void Show(bool force = false)
        {
            if (IsComplete && !force)
                return;

            Logger.Log(LogLevel.Info, "Showing wizard...");

            using var dial = new OobeWizard();
            var result = dial.ShowDialog();

            if (result != DialogResult.OK)
            {
                Logger.Log(LogLevel.Warn, "Please complete setup.");
                Environment.Exit(1);
            }
        }
    }
}
