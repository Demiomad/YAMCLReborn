using System;
using CmlLib.Core;
using System.Collections.Generic;
using System.Text;
using CmlLib.Core.Java;
using YAMCLReborn.Core.Modding;
using System.Text.Json.Serialization;

namespace YAMCLReborn.Core.Instances
{
    /// <summary>
    /// Represents a Minecraft instance.
    /// </summary>
    public record Instance
    {
        /// <summary>
        /// The instance's name.
        /// </summary>
        public string? Name { get; init; }

        /// <summary>
        /// The instance's icon file.
        /// </summary>
        public string? IconFile { get; init; }

        /// <summary>
        /// The instance's ".minecraft" folder path.
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// The version that gets used to install any mod loaders, etc.
        /// </summary>
        public string? BaseVersion { get; set; }

        /// <summary>
        /// The version that gets used to launch the game.
        /// </summary>
        public string? Version { get; set; }

        /// <summary>
        /// The <see cref="MinecraftPath"/> of the instance's path.
        /// </summary>
        [JsonIgnore]
        public MinecraftPath McPath => new(Path!);

        /// <summary>
        /// The Minecraft launcher object used to launch the instance.
        /// </summary>
        [JsonIgnore]
        public MinecraftLauncher? Launcher { get; init; }

        /// <summary>
        /// The launcher's parameters.
        /// </summary>
        [JsonIgnore]
        public MinecraftLauncherParameters? Params { get; init; }

        /// <summary>
        /// The instance's mod loader.
        /// </summary>
        public ModLoader Loader { get; set; }

        public Instance()
        {
            Loader = new()
            {
                Kind = ModLoaderKind.Vanilla,
                Version = BaseVersion
            };

            Path = MinecraftPath.GetOSDefaultPath();
            Params = MinecraftLauncherParameters.CreateDefault();
            Params.MinecraftPath = McPath;

            Launcher = new(Params);
        }
    }
}
