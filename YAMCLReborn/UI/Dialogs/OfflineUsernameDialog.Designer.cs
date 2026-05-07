namespace YAMCLReborn.UI.Dialogs
{
    partial class OfflineUsernameDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            okBtn = new Button();
            cancelBtn = new Button();
            usernameBox = new TextBox();
            usernameBoxLbl = new Label();
            legacySessionChk = new CheckBox();
            SuspendLayout();
            // 
            // okBtn
            // 
            okBtn.DialogResult = DialogResult.OK;
            okBtn.Location = new Point(334, 88);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(75, 23);
            okBtn.TabIndex = 0;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += OkBtnClicked;
            // 
            // cancelBtn
            // 
            cancelBtn.DialogResult = DialogResult.Cancel;
            cancelBtn.Location = new Point(12, 88);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 1;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(12, 30);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(397, 22);
            usernameBox.TabIndex = 2;
            // 
            // usernameBoxLbl
            // 
            usernameBoxLbl.AutoSize = true;
            usernameBoxLbl.Location = new Point(12, 10);
            usernameBoxLbl.Name = "usernameBoxLbl";
            usernameBoxLbl.Size = new Size(70, 17);
            usernameBoxLbl.TabIndex = 3;
            usernameBoxLbl.Text = "Username:";
            // 
            // legacySessionChk
            // 
            legacySessionChk.AutoSize = true;
            legacySessionChk.Location = new Point(12, 61);
            legacySessionChk.Name = "legacySessionChk";
            legacySessionChk.Size = new Size(114, 21);
            legacySessionChk.TabIndex = 4;
            legacySessionChk.Text = "Legacy session";
            legacySessionChk.UseVisualStyleBackColor = true;
            // 
            // OfflineUsernameDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 123);
            Controls.Add(legacySessionChk);
            Controls.Add(usernameBoxLbl);
            Controls.Add(usernameBox);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OfflineUsernameDialog";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Offline Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button okBtn;
        private Button cancelBtn;
        private TextBox usernameBox;
        private Label usernameBoxLbl;
        private CheckBox legacySessionChk;
    }
}