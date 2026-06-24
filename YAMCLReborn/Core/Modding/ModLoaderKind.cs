using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace YAMCLReborn.Core.Modding
{
    /// <summary>
    /// Represents a mod loader.
    /// </summary>
    public enum ModLoaderKind
    {
        Fabric,
        Forge,
        NeoForge,
        Quilt,
        LiteLoader,

        [Display(Name = "Vanilla (No Mods)")]
        Vanilla
    }
}
