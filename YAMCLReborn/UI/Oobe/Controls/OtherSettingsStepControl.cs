using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using YAMCLReborn.Core.Config;
using YAMCLReborn.Core.Oobe.Steps;

namespace YAMCLReborn.UI.Oobe.Controls
{
    public partial class OtherSettingsStepControl : UserControl
    {
        private OtherSettingsStep _step;

        public OtherSettingsStepControl(OtherSettingsStep step)
        {
            InitializeComponent();

            _step = step;
            _step.CanContinue = true;
            _step.LogToFile = logToFileChk.Checked;
            _step.ShowConsole = showConsoleChk.Checked;

            javaPathBox.Text = ConfigManager.CurrentConfig.JavaPath;
        }

        private void BrowseJavaBtnClicked(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog();

            dialog.Title = "Select the Java executable...";
            dialog.FileName = "javaw.exe";
            dialog.Filter = "Executable Files (*.exe)|*.exe";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                javaPathBox.Text = dialog.FileName;
                _step.JavaPath = dialog.FileName;
            }
        }

        private void ShowConsoleChkChanged(object sender, EventArgs e)
        {
            _step.ShowConsole = showConsoleChk.Checked;
        }

        private void LogToFileChkChanged(object sender, EventArgs e)
        {
            _step.LogToFile = logToFileChk.Checked;
        }
    }
}
