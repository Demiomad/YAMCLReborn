using CmlLib.Core.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using YAMCLReborn.Core;
using YAMCLReborn.Core.Oobe.Steps;
using YAMCLReborn.UI.Dialogs;
using YAMCLReborn.UI.Utils;

namespace YAMCLReborn.UI.Oobe.Controls
{
    public partial class AccountStepControl : UserControl
    {
        private AccountStep _step;

        public AccountStepControl(AccountStep step)
        {
            InitializeComponent();

            _step = step;
            UpdateUsernameLbl();
        }

        private void UpdateUsernameLbl()
        {
            if (Globals.CurrentSession == null)
                signedInAsLbl.Text = "You're not signed in!";
            else
                signedInAsLbl.Text = $"Currently signed in as {Globals.CurrentSession.Username}";
        }

        private async void MsLoginBtnClicked(object sender, EventArgs e)
        {
            try
            {
                Globals.BuildLoginHandler();

                Globals.CurrentSession = await Globals.LoginHandler?.AuthenticateInteractively()!;
                _step.OnSignedIn();
            }
            catch (OperationCanceledException)
            {
                TaskDialogHelper.ShowDialog("Canceled operation", string.Empty, "The operation was canceled.", TaskDialogIcon.Warning);
            }
            catch (Exception ex)
            {
                TaskDialogHelper.ShowDialog(ex.Message, "Something went wrong", ex.ToString(), TaskDialogIcon.Error);
            }

            UpdateUsernameLbl();
        }

        private void OfflineLoginBtnClicked(object sender, EventArgs e)
        {
            try
            {
                using var dialog = new OfflineUsernameDialog();

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (!dialog.LegacySession)
                        Globals.CurrentSession = MSession.CreateOfflineSession(dialog.Username!);
                    else
                        Globals.CurrentSession = MSession.CreateLegacyOfflineSession(dialog.Username!);

                    _step.OnSignedIn();
                }
            }
            catch (Exception ex)
            {
                TaskDialogHelper.ShowDialog(ex.Message, "Something went wrong", ex.ToString(), TaskDialogIcon.Error);
            }

            UpdateUsernameLbl();
        }
    }
}
