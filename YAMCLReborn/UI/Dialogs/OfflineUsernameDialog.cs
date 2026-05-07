using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using YAMCLReborn.UI.Utils;

namespace YAMCLReborn.UI.Dialogs
{
    public partial class OfflineUsernameDialog : Form
    {
        /// <summary>
        /// The username to use for the offline account.
        /// </summary>
        public string? Username { get; private set; }

        /// <summary>
        /// Whether the session is a legacy session.
        /// </summary>
        public bool LegacySession { get; private set; }

        public OfflineUsernameDialog()
        {
            InitializeComponent();
        }

        private void OkBtnClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameBox.Text))
            {
                TaskDialogHelper.ShowDialog("Invalid username", "Please enter an username!", "The username cannot be empty.", TaskDialogIcon.Warning);
                return;
            }

            Username = usernameBox.Text;
            LegacySession = legacySessionChk.Checked;
        }
    }
}
