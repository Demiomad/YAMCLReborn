using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace YAMCLReborn.Core.Config
{
    /// <summary>
    /// Manages the current configuration.
    /// </summary>
    public static class ConfigManager
    {
        /// <summary>
        /// Represents the configuration's entries.
        /// </summary>
        public static Config CurrentConfig { get; set; } = new Config();

        /// <summary>
        /// Loads the configuration from a file.
        /// </summary>
        public static void Load()
        {
            if (!File.Exists(Paths.ConfigFile))
            {
                CurrentConfig = new Config();
                return;
            }

            try
            {
                var json = File.ReadAllText(Paths.ConfigFile);
                CurrentConfig = JsonSerializer.Deserialize<Config>(json) ?? new Config();
            }
            catch (JsonException)
            {
                CurrentConfig = new Config();
            }
        }

        /// <summary>
        /// Saves the configuration to a file.
        /// </summary>
        public static void Save()
        {
            var json = JsonSerializer.Serialize(CurrentConfig);
            File.WriteAllText(Paths.ConfigFile, json);
        }
    }
}
