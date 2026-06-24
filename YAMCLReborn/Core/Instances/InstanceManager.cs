using CmlLib.Core.Installer.Forge;
using CmlLib.Core.Installer.NeoForge;
using CmlLib.Core.Installer.NeoForge.Installers;
using CmlLib.Core.ModLoaders.FabricMC;
using CmlLib.Core.ModLoaders.LiteLoader;
using CmlLib.Core.ModLoaders.QuiltMC;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.Json;
using YAMCLReborn.Core.Config;
using YAMCLReborn.Core.Logging;
using YAMCLReborn.UI.Utils;

namespace YAMCLReborn.Core.Instances
{
    /// <summary>
    /// Manages all Minecraft instances.
    /// </summary>
    public static class InstanceManager
    {
        /// <summary>
        /// The list of instances.
        /// </summary>
        public static List<Instance> Instances { get; private set; } = [];

        /// <summary>
        /// Loads all instances from disk.
        /// </summary>
        public static void Load()
        {
            if (!Directory.Exists(Paths.InstancesPath))
                Directory.CreateDirectory(Paths.InstancesPath);

            foreach (var dir in Directory.GetDirectories(Paths.InstancesPath))
            {
                LoadFromDirectory(dir);
            }
        }

        /// <summary>
        /// Deletes an instance.
        /// </summary>
        /// <param name="name">The instance's name.</param>
        public static void Delete(string name)
        {
            var instance = Instances.FirstOrDefault(i => i.Name == name);

            if (instance == null)
                return;

            Delete(instance);
        }

        /// <summary>
        /// Deletes an instance.
        /// </summary>
        /// <param name="instance">The instance to delete.</param>
        public static void Delete(Instance instance)
        {
            try
            {
                var instanceDir = new DirectoryInfo(instance.Path).Parent;
                instanceDir?.Delete(true);

                Instances.Remove(instance);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Loads an instance by using the provided directory.
        /// </summary>
        /// <param name="dir">The instance's root directory.</param>
        public static void LoadFromDirectory(string dir)
        {
            try
            {
                var cfgFile = Path.Combine(dir, "instance.json");

                if (!File.Exists(cfgFile))
                {
                    Logger.Log(LogLevel.Error, $"\"{dir}\" is missing \"instance.json\", ignoring");
                    return;
                }

                var mcFolder = Path.Combine(dir, ".minecraft"); // It won't exist, but that's fine.

                var json = File.ReadAllText(cfgFile);
                var deserialized = JsonSerializer.Deserialize<Instance>(json)! with
                {
                    Path = mcFolder
                };

                if (deserialized != null)
                    Instances.Add(deserialized);
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Error, $"Failed to load instance from \"{dir}\": {ex.Message}");
            }
        }

        /// <summary>
        /// Launches an instance.
        /// </summary>
        /// <param name="name">The name of the instance to launch.</param>
        /// <returns>The instance's process.</returns>
        public static async Task<Process?> Launch(string name)
        {
            var instance = Instances.FirstOrDefault(i => i.Name == name);

            if (instance == null)
                return null;

            return await Start(instance);
        }

        private static async void InstallLoader(string javaPath, Instance instance)
        {
            try
            {
                switch (instance.Loader.Kind)
                {
                    case Modding.ModLoaderKind.Fabric:
                        var fabricInstaller = new FabricInstaller(Globals.Http);

                        if (instance.Loader.Version == "latest")
                            instance.Version = await fabricInstaller.Install(instance.BaseVersion!, instance.McPath);
                        else
                            instance.Version = await fabricInstaller.Install(instance.BaseVersion!,
                                instance.Loader.Version!,
                                instance.McPath);

                        break;

                    case Modding.ModLoaderKind.Forge:
                        // Unfortunately cmllib doesnt let you install a specific version of forge for some reason
                        var forgeInstaller = new ForgeInstaller(instance.Launcher!, Globals.Http);
                        instance.Version = await forgeInstaller.Install(instance.BaseVersion!, new ForgeInstallOptions()
                        {
                            JavaPath = javaPath,
                        });

                        break;

                    case Modding.ModLoaderKind.NeoForge:
                        // Same goes for neoforge
                        var neoForgeInstaller = new NeoForgeInstaller(instance.Launcher!);
                        instance.Version = await neoForgeInstaller.Install(instance.BaseVersion!, new NeoForgeInstallOptions()
                        {
                            JavaPath = javaPath
                        });

                        break;

                    case Modding.ModLoaderKind.Quilt:
                        var quiltInstaller = new QuiltInstaller(Globals.Http);

                        if (instance.Loader.Version == "latest")
                            instance.Version = await quiltInstaller.Install(instance.BaseVersion!, instance.McPath);
                        else
                            instance.Version = await quiltInstaller.Install(instance.BaseVersion!,
                                instance.Loader.Version!,
                                instance.McPath);

                        break;

                    case Modding.ModLoaderKind.LiteLoader:
                        var liteLoaderInstaller = new LiteLoaderInstaller(Globals.Http);
                        var versions = await liteLoaderInstaller.GetAllLiteLoaders();

                        var version = versions.First(v =>
                        {
                            if (instance.Loader.Version == "latest")
                                return v.BaseVersion == instance.Version;

                            return v.BaseVersion == instance.Version && v.Version == instance.Loader!.Version;
                        });

                        instance.Version = await liteLoaderInstaller.Install(version,
                            await instance.Launcher!.GetVersionAsync(instance.BaseVersion!),
                            instance.McPath);

                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Error, $"Failed to install {instance.Loader.Kind}: {ex.Message}");
            }
        }

        /// <summary>
        /// Saves all instances to disk.
        /// </summary>
        public static void Save()
        {
            foreach (var instance in Instances)
            {
                var instanceDir = new DirectoryInfo(instance.Path).Parent;
                var json = JsonSerializer.Serialize(instance);

                var jsonPath = Path.Combine(instanceDir!.FullName, "instance.json");
                File.WriteAllText(jsonPath, json);
            }
        }

        /// <summary>
        /// Creates a new instance.
        /// </summary>
        /// <param name="instance">The instance to create.</param>
        public static void New(Instance instance)
        {
            if (string.IsNullOrEmpty(instance.Name)) return;

            var name = string.Join("-", instance.Name.Split(Path.GetInvalidFileNameChars()));
            var instanceDir = Path.Combine(Paths.InstancesPath, name);

            if (!Directory.Exists(instanceDir))
                Directory.CreateDirectory(instanceDir);

            var instanceFile = Path.Combine(instanceDir, "instance.json");
            var json = JsonSerializer.Serialize(instance);
            File.WriteAllText(instanceFile, json);

            Instances.Add(instance);
        }

        /// <summary>
        /// Start an instance.
        /// </summary>
        /// <param name="instance">The instance to start.</param>
        /// <returns>The instance's process.</returns>
        public static async Task<Process?> Start(Instance instance,
            Action<long, long, double>? onByteProgressChanged = null,
            Action<long, long, string?>? onFileProgressChanged = null)
        {
            if (string.IsNullOrEmpty(instance.Version) || instance.Launcher == null)
            {
                Logger.Log(LogLevel.Fatal, "Version or launcher are null");
                return null;
            }

            var javaPath = ConfigManager.CurrentConfig.JavaPath 
                ?? instance.Launcher?.GetDefaultJavaPath();

            InstallLoader(javaPath ?? string.Empty, instance);

            instance.Launcher?.ByteProgressChanged += (s, e) 
                => onByteProgressChanged?.Invoke(e.ProgressedBytes, e.TotalBytes, Math.Round(e.ToRatio() * 100));

            instance.Launcher?.FileProgressChanged += (s, e)
                => onFileProgressChanged?.Invoke(e.ProgressedTasks, e.TotalTasks, e.Name);

            var proc = await instance.Launcher!.InstallAndBuildProcessAsync(instance.Version, new CmlLib.Core.ProcessBuilder.MLaunchOption()
            {
                Session = Globals.CurrentSession,
                MaximumRamMb = 4096,
                JavaPath = javaPath
            });
            return proc;
        }
    }
}
