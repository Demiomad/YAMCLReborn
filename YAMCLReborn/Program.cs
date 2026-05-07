using System.Runtime.InteropServices;
using YAMCLReborn.Core;
using YAMCLReborn.Core.Config;
using YAMCLReborn.Core.Instances;
using YAMCLReborn.Core.Logging;
using YAMCLReborn.Core.Oobe;
using YAMCLReborn.UI.Utils;

namespace YAMCLReborn
{
    internal static class Program
    {
        [DllImport("kernel32.dll")]
        private static extern void AllocConsole();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            if (!Directory.Exists(Paths.ProgramPath))
                Directory.CreateDirectory(Paths.ProgramPath);

            if (!Directory.Exists(Paths.LogsPath))
                Directory.CreateDirectory(Paths.LogsPath);

            ConfigManager.Load();
            ConfigManager.CurrentConfig.JavaPath ??= Globals.Launcher.GetDefaultJavaPath();

            if (ConfigManager.CurrentConfig.ShowDebugWindow)
            {
                AllocConsole();
                Console.Title = "YAMCL Debug Window";
            }

            Logger.Log(LogLevel.Info, "Loading instances");
            InstanceManager.Load();
            OobeManager.Show();

            if (InstanceManager.Instances.Count != 0)
                foreach (var instance in InstanceManager.Instances)
                    Logger.Log(LogLevel.Info, $"Found instance {instance.Name} ({instance.Version})");
            else
                Logger.Log(LogLevel.Info, "No instances found");

            if (OobeManager.IsComplete)
                Application.Run(new MainForm());

            Logger.Log(LogLevel.Info, "Saving config");
            ConfigManager.Save();

            Logger.Log(LogLevel.Info, "Saving instances");
            InstanceManager.Save();

            Logger.Log(LogLevel.Info, "Disposing HTTP client");
            Globals.Http.Dispose();

            Logger.Log(LogLevel.Info, "Goodbye!");
        }
    }
}