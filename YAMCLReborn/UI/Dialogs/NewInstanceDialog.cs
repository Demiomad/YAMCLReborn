using CmlLib.Core.VersionMetadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using YAMCLReborn.Core;
using YAMCLReborn.Core.Logging;
using YAMCLReborn.Core.Modding;
using YAMCLReborn.UI.Utils;

namespace YAMCLReborn.UI.Dialogs
{
    public partial class NewInstanceDialog : Form
    {
        public string? InstanceName { get; private set; }
        public string? InstanceVersion { get; private set; }
        public string? LoaderVersion { get; private set; } = "latest";
        public ModLoaderKind LoaderKind { get; private set; }

        private VersionMetadataCollection _versions;

        public NewInstanceDialog()
        {
            InitializeComponent();
        }

        private void CancelBtnClicked(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void CreateBtnClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(instanceNameBox.Text))
                InstanceName = instanceNameBox.Text;
            else
                InstanceName = $"Instance{Random.Shared.Next(1, int.MaxValue)}";

            if (versionListBox.SelectedIndex != -1)
                InstanceVersion = _versions[versionListBox.SelectedIndex].Name ?? _versions.LatestReleaseName!;
            else
                InstanceVersion = _versions != null ? _versions.LatestReleaseName! : "1.21";

            LoaderVersion = loaderVerBox.Text ?? "latest";

            if (loaderKindBox.SelectedIndex != -1)
                LoaderKind = (ModLoaderKind)loaderKindBox.SelectedIndex;
            else
                LoaderKind = ModLoaderKind.Vanilla;

            DialogResult = DialogResult.OK;
            Close();
        }

        private async void NewInstanceDialogLoaded(object sender, EventArgs e)
        {
            try
            {
                _versions = await Globals.Launcher.GetAllVersionsAsync();

                foreach (var version in _versions)
                    versionListBox.Items.Add($"{version.Type} {version.Name}");

                foreach (var loader in Enum.GetNames<ModLoaderKind>())
                    loaderKindBox.Items.Add(loader);
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Error, $"Failed to load versions: {ex.Message}");
                TaskDialogHelper.ShowDialog(ex.Message, $"Something went wrong", ex.ToString(), TaskDialogIcon.Error);
            }
        }
    }
}
