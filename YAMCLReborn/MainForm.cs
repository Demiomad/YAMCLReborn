using CmlLib.Core.ProcessBuilder;
using YAMCLReborn.Core;
using YAMCLReborn.Core.Instances;
using YAMCLReborn.Core.Logging;
using YAMCLReborn.Core.Oobe;
using YAMCLReborn.UI.Dialogs;
using YAMCLReborn.UI.Utils;

namespace YAMCLReborn
{
    public partial class MainForm : Form
    {
        private static List<Instance> _oldInstances = [];

        public MainForm()
        {
            InitializeComponent();
            ShowInstances();

            _oldInstances = InstanceManager.Instances.ToList();
        }

        private void ShowInstances()
        {
            instanceListBox.Items.Clear();

            foreach (var instance in InstanceManager.Instances)
                instanceListBox.Items.Add($"{instance.Name} ({instance.BaseVersion})");
        }

        private void RefreshInstances()
        {
            Logger.Log(LogLevel.Info, "Refreshing instances");

            _oldInstances = InstanceManager.Instances.ToList();

            InstanceManager.Instances.Clear();
            InstanceManager.Load();

            foreach (var instance in InstanceManager.Instances)
                if (!_oldInstances.Any(i => i.Name == instance.Name))
                    Logger.Log(LogLevel.Info, $"New instance found: {instance.Name} ({instance.Version})");

            ShowInstances();
        }

        private void RefreshStripBtnClicked(object sender, EventArgs e)
        {
            RefreshInstances();
        }

        private void InstanceListBoxSelectionChanged(object sender, EventArgs e)
        {
            if (instanceListBox.SelectedIndex == -1 ||
                instanceListBox.SelectedIndex > InstanceManager.Instances.Count)
                return;

            var instance = InstanceManager.Instances[instanceListBox.SelectedIndex];

            instanceNameLbl.Text = instance.Name;
            instanceVersionLbl.Text = $"Version: {instance.Version}";
            instanceModLoaderLbl.Text = $"Mod Loader: {instance.Loader.Kind} {instance.Loader.Version}";

            if (File.Exists(instance.IconFile))
                instanceIcon.ImageLocation = instance.IconFile;

            instPropertyGrid.SelectedObject = instance;
        }

        private void DelInstanceBtnClicked(object sender, EventArgs e)
        {
            if (instanceListBox.SelectedIndex == -1)
            {
                TaskDialogHelper.ShowDialog("Error", "No instance selected",
                    "You must select an instance!", TaskDialogIcon.Error);

                return;
            }

            var instance = InstanceManager.Instances[instanceListBox.SelectedIndex];

            var result = TaskDialogHelper.ShowDialog("Wait a second!", $"Are you sure you want to delete \"{instance.Name}\"?",
                "It will be gone forever (a long time!)\n" +
                "You will not be able to undo this operation.", TaskDialogIcon.Warning, TaskDialogButton.Yes, TaskDialogButton.No);

            if (result == TaskDialogButton.Yes)
            {
                try
                {
                    Logger.Log(LogLevel.Info, $"Deleting instance {instance.Name}");
                    InstanceManager.Delete(instance);

                    ShowInstances();

                    instanceNameLbl.Text = "[DELETED INSTANCE]";
                    instanceVersionLbl.Text = "Deleted instance";
                    instPropertyGrid.SelectedObject = null;
                    instanceIcon.Image = null;
                }
                catch (Exception ex)
                {
                    Logger.Log(LogLevel.Error, $"Failed to delete instance: {ex.Message}");
                    TaskDialogHelper.ShowDialog(ex.Message, $"Something went wrong", ex.ToString(), TaskDialogIcon.Error);
                }
            }
        }

        private void RerunSetupStripBtnClicked(object sender, EventArgs e)
        {
            var result = TaskDialogHelper.ShowDialog("Wait a second!",
                "Are you sure you want to re-run setup?", "Your settings will be reset to default.",
                TaskDialogIcon.Warning, TaskDialogButton.Yes, TaskDialogButton.No);

            if (result == TaskDialogButton.Yes)
            {
                Hide();
                OobeManager.Show(true);
                Show();
            }
        }

        private void NewStripBtnClicked(object sender, EventArgs e)
        {
            using var dialog = new NewInstanceDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrWhiteSpace(dialog.InstanceName))
                {
                    TaskDialogHelper.ShowDialog("Error", "Invalid name", "Instance name cannot be empty", TaskDialogIcon.Error);
                    return;
                }

                var inst = new Instance()
                {
                    Name = dialog.InstanceName,
                    Version = dialog.InstanceVersion,
                    BaseVersion = dialog.InstanceVersion,
                    Path = Path.Combine(Paths.InstancesPath, dialog.InstanceName, ".minecraft"),
                    Loader = new Core.Modding.ModLoader()
                    {
                        Kind = dialog.LoaderKind,
                        Version = dialog.LoaderVersion
                    }
                };

                InstanceManager.New(inst);
                ShowInstances();
            }
        }

        private async void LaunchBtnClicked(object sender, EventArgs e)
        {
            if (instanceListBox.SelectedIndex == -1)
            {
                TaskDialogHelper.ShowDialog("Error", "No instance selected",
                    "You must select an instance!", TaskDialogIcon.Error);

                return;
            }

            var instance = InstanceManager.Instances[instanceListBox.SelectedIndex];

            Logger.Log(LogLevel.Info, $"Launching instance \"{instance.Name}\"");
            Logger.Log(LogLevel.Info, "Instance info:");
            Logger.Log(LogLevel.Info, $"Mod loader: {instance.Loader.Kind} {instance.Loader.Version}");
            Logger.Log(LogLevel.Info, $"Game version: {instance.BaseVersion}");
            Logger.Log(LogLevel.Info, $"Icon file: {instance.IconFile ?? "None"}");

            var proc = await InstanceManager.Start(instance, (procBytes, totalBytes, percent) =>
            {
                Invoke(() => byteProgBar.Value = (int)percent);
                Logger.Log(LogLevel.Info, $"Byte progress: {procBytes}/{totalBytes} ({percent}%)");
            },
            (procFiles, totalFiles, name) =>
            {
                var percent = Math.Round((double)(procFiles / totalFiles * 100));
                Invoke(() => fileProgBar.Value = (int)percent);

                Logger.Log(LogLevel.Info, $"File progress of {name}: {procFiles}/{totalFiles} ({percent}%)");
            });
            Logger.Log(LogLevel.Info, $"Starting Minecraft process");

            if (proc == null)
                return;

            var wrapper = new ProcessWrapper(proc);

            wrapper.OutputReceived += (s, e)
                => Logger.Log(LogLevel.Info, $"Output received: {e}");

            wrapper.Exited += (s, e)
                => Logger.Log(LogLevel.Info, "Minecraft exited");

            wrapper.StartWithEvents();
            await wrapper.WaitForExitTaskAsync();
        }

        private void InstPropertyGridPropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            var selectedIndex = instanceListBox.SelectedIndex;

            InstanceManager.Save();
            RefreshInstances();

            if (selectedIndex > instanceListBox.Items.Count || selectedIndex < 0)
                return;

            instanceListBox.SelectedIndex = selectedIndex;
        }
    }
}
