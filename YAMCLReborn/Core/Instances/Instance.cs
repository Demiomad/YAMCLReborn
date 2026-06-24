using System;
using CmlLib.Core;
using System.Collections.Generic;
using System.Text;
using CmlLib.Core.Java;
using YAMCLReborn.Core.Modding;
using System.Text.Json.Serialization;
using System.ComponentModel;
using System.Windows.Forms.Design;
using System.Drawing.Design;

namespace YAMCLReborn.Core.Instances
{
    /// <summary>
    /// Represents a Minecraft instance.
    /// </summary>
    public record Instance
    {
        /// <summary>
        /// Gets or sets this instance's name.
        /// </summary>
        [DisplayName("Name"),
            Description("The name of this instance."),
            Category("Instance")]
        public string? Name { get; init; }

        /// <summary>
        /// Gets or sets the path of this instance's icon file.
        /// </summary>
        [DisplayName("Icon"),
            Description("The icon of this instance."),
            Editor(typeof(FileNameEditor), typeof(UITypeEditor)),
            Category("Instance")]
        public string? IconFile { get; init; }

        /// <summary>
        /// Gets or sets this instance's ".minecraft" folder path.
        /// </summary>
        [DisplayName("Path"),
            Description("The path of this instance's \".minecraft\" folder."),
            ReadOnly(true),
            Category("Game")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the version that gets used to install any mod loaders, etc.
        /// </summary>
        [DisplayName("Game Version"),
            Description("The game's version."),
            Category("Game")]
        public string? BaseVersion { get; set; }

        /// <summary>
        /// Gets or sets the version that gets used to launch the game.
        /// </summary>
        [Browsable(false)]
        public string? Version { get; set; }

        /// <summary>
        /// Gets the <see cref="MinecraftPath"/> of the instance's path.
        /// </summary>
        [JsonIgnore,
            Browsable(false)]
        public MinecraftPath McPath => new(Path!);

        /// <summary>
        /// Gets the Minecraft launcher object used to launch the instance.
        /// </summary>
        [JsonIgnore,
            Browsable(false)]
        public MinecraftLauncher? Launcher { get; init; }

        /// <summary>
        /// Gets the launcher's parameters.
        /// </summary>
        [JsonIgnore,
            Browsable(false)]
        public MinecraftLauncherParameters? Params { get; init; }

        /// <summary>
        /// Gets or sets the instance's mod loader.
        /// </summary>
        [DisplayName("Mod Loader"),
            Description("The mod loader to use."),
            Category("Modding")]
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
