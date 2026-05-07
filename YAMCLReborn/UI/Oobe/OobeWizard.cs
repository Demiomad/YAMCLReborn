using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using YAMCLReborn.Core.Oobe.Steps;
using YAMCLReborn.Core.Oobe;
using YAMCLReborn.UI.Oobe.Controls;
using YAMCLReborn.UI.Utils;
using YAMCLReborn.Core.Logging;

namespace YAMCLReborn.UI.Oobe
{
    public partial class OobeWizard : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<OobeStep> Steps { get; set; }

        private int _currentStep;
        private OobeStep? _currentStepObj;

        public OobeWizard()
        {
            InitializeComponent();

            Steps = [
                new WelcomeStep(),
                new AccountStep(),
                new OtherSettingsStep()
            ];

            LoadStep(0);
        }

        private Control? GetControlForStep(OobeStep step) => step switch
        {
            AccountStep s => new AccountStepControl(s),
            WelcomeStep s => new WelcomeStepControl(s),
            OtherSettingsStep s => new OtherSettingsStepControl(s),
            _ => null
        };

        private void OnCanContinueChanged(object? sender, EventArgs e)
            => nextBtn.Enabled = _currentStepObj?.CanContinue ?? false;

        /// <summary>
        /// Loads a step.
        /// </summary>
        public void LoadStep(int stepIndex)
        {
            _currentStep = stepIndex;

            var step = Steps[stepIndex];
            var ctrl = GetControlForStep(step);

            if (_currentStepObj != null)
                _currentStepObj.OnCanContinueChanged -= OnCanContinueChanged;

            _currentStepObj = step;
            _currentStepObj.OnCanContinueChanged += OnCanContinueChanged;

            stepCountLbl.Text = $"Step {stepIndex + 1}/{Steps.Count}";
            Text = _currentStepObj.WindowTitle;

            contentPnl.Controls.Clear();

            ctrl?.Left = 0;
            ctrl?.Top = 0;
            ctrl?.Dock = DockStyle.Fill;
            contentPnl.Controls.Add(ctrl);

            nextBtn.Enabled = _currentStepObj.CanContinue;
            nextBtn.Text = stepIndex == Steps.Count - 1 ? "Finish" : "Next >";
            backBtn.Enabled = stepIndex > 0;

            Logger.Log(LogLevel.Info, $"Loading step {stepIndex}");
        }

        private void NextBtnClicked(object sender, EventArgs e)
        {
            _currentStepObj?.OnNextClicked();

            if (_currentStep == Steps.Count - 1)
            {
                Logger.Log(LogLevel.Info, "Setup complete, marking OOBE as complete...");
                OobeManager.MarkComplete();
                DialogResult = DialogResult.OK;
                Close();
                return;
            }

            LoadStep(++_currentStep);
        }

        private void BackBtnClicked(object sender, EventArgs e)
            => LoadStep(--_currentStep);

        private void OobeWizardClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK) return;

            var result = TaskDialogHelper.ShowDialog("Wait a second!", "Are you sure you want to exit?",
                "You won't be able to use YAMCL: Reborn until setup is complete.",
                TaskDialogIcon.Warning, TaskDialogButton.Yes, TaskDialogButton.No);

            e.Cancel = result == TaskDialogButton.No;
        }
    }
}
