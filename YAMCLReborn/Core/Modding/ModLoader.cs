using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace YAMCLReborn.Core.Modding
{
    /// <summary>
    /// Represents a mod loader.
    /// </summary>
    public class ModLoader
    {
        /// <summary>
        /// The mod loader's version. Use 'latest' if you want the latest version.
        /// </summary>
        public string? Version { get; set; }

        /// <summary>
        /// The mod loader's kind.
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ModLoaderKind Kind { get; set; }
    }
}
