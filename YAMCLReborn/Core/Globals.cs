using CmlLib.Core;
using CmlLib.Core.Auth;
using CmlLib.Core.Auth.Microsoft;
using CmlLib.Core.Auth.Microsoft.Authenticators;
using System;
using System.Collections.Generic;
using System.Text;
using XboxAuthNet.Game.Authenticators;

namespace YAMCLReborn.Core
{
    /// <summary>
    /// Global values.
    /// </summary>
    public static class Globals
    {
        /// <summary>
        /// The current login handler.
        /// </summary>
        public static JELoginHandler? LoginHandler { get; set; }

        /// <summary>
        /// The current session.
        /// </summary>
        public static MSession? CurrentSession { get; set; }

        /// <summary>
        /// The main HTTP client used for downloading files.
        /// </summary>
        public static HttpClient Http { get; set; } = new();

        /// <summary>
        /// The main launcher. Used getting all the available Minecraft versions.
        /// Don't ask me why CmlLib decided to do it that way.
        /// </summary>
        public static MinecraftLauncher Launcher { get; } = new();

        /// <summary>
        /// Builds the login handler.
        /// </summary>
        public static void BuildLoginHandler()
        {
            if (LoginHandler != null)
                return;

            LoginHandler = JELoginHandlerBuilder.BuildDefault();
        }
    }
}
