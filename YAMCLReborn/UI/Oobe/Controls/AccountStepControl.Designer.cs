namespace YAMCLReborn.UI.Oobe.Controls
{
    partial class AccountStepControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerLbl = new Label();
            msLoginBtn = new Button();
            offlineLoginBtn = new Button();
            msLoginDesc = new Label();
            offlineLoginDesc = new Label();
            signedInAsLbl = new Label();
            descriptionLbl = new Label();
            SuspendLayout();
            // 
            // headerLbl
            // 
            headerLbl.AutoSize = true;
            headerLbl.Font = new Font("Inter", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLbl.Location = new Point(0, 0);
            headerLbl.Name = "headerLbl";
            headerLbl.Size = new Size(159, 30);
            headerLbl.TabIndex = 0;
            headerLbl.Text = "Time to log in!";
            // 
            // msLoginBtn
            // 
            msLoginBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            msLoginBtn.Font = new Font("Inter", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            msLoginBtn.Location = new Point(98, 183);
            msLoginBtn.Name = "msLoginBtn";
            msLoginBtn.Size = new Size(185, 40);
            msLoginBtn.TabIndex = 2;
            msLoginBtn.Text = "Microsoft Login";
            msLoginBtn.UseVisualStyleBackColor = true;
            msLoginBtn.Click += MsLoginBtnClicked;
            // 
            // offlineLoginBtn
            // 
            offlineLoginBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            offlineLoginBtn.Font = new Font("Inter", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            offlineLoginBtn.Location = new Point(415, 183);
            offlineLoginBtn.Name = "offlineLoginBtn";
            offlineLoginBtn.Size = new Size(185, 40);
            offlineLoginBtn.TabIndex = 4;
            offlineLoginBtn.Text = "Offline Login";
            offlineLoginBtn.UseVisualStyleBackColor = true;
            offlineLoginBtn.Click += OfflineLoginBtnClicked;
            // 
            // msLoginDesc
            // 
            msLoginDesc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            msLoginDesc.AutoSize = true;
            msLoginDesc.Location = new Point(80, 226);
            msLoginDesc.Name = "msLoginDesc";
            msLoginDesc.Size = new Size(226, 34);
            msLoginDesc.TabIndex = 3;
            msLoginDesc.Text = "Allows you to join multiplayer servers,\r\nbut requires a valid Minecraft account.";
            msLoginDesc.TextAlign = ContentAlignment.TopCenter;
            // 
            // offlineLoginDesc
            // 
            offlineLoginDesc.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            offlineLoginDesc.AutoSize = true;
            offlineLoginDesc.Location = new Point(398, 226);
            offlineLoginDesc.Name = "offlineLoginDesc";
            offlineLoginDesc.Size = new Size(216, 51);
            offlineLoginDesc.TabIndex = 5;
            offlineLoginDesc.Text = "Allows you to play the game offline,\r\nbut prevents you from joining certain\r\nmultiplayer servers.";
            offlineLoginDesc.TextAlign = ContentAlignment.TopCenter;
            // 
            // signedInAsLbl
            // 
            signedInAsLbl.AutoSize = true;
            signedInAsLbl.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signedInAsLbl.Location = new Point(3, 47);
            signedInAsLbl.Name = "signedInAsLbl";
            signedInAsLbl.Size = new Size(122, 17);
            signedInAsLbl.TabIndex = 6;
            signedInAsLbl.Text = "You're not singed in!";
            // 
            // descriptionLbl
            // 
            descriptionLbl.AutoSize = true;
            descriptionLbl.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionLbl.Location = new Point(3, 30);
            descriptionLbl.Name = "descriptionLbl";
            descriptionLbl.Size = new Size(474, 17);
            descriptionLbl.TabIndex = 1;
            descriptionLbl.Text = "No Minecraft account? No problem! You can sign in with an offline account instead.";
            // 
            // AccountStepControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(signedInAsLbl);
            Controls.Add(offlineLoginDesc);
            Controls.Add(offlineLoginBtn);
            Controls.Add(msLoginDesc);
            Controls.Add(msLoginBtn);
            Controls.Add(descriptionLbl);
            Controls.Add(headerLbl);
            Name = "AccountStepControl";
            Size = new Size(700, 400);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLbl;
        private Button msLoginBtn;
        private Button offlineLoginBtn;
        private Label msLoginDesc;
        private Label offlineLoginDesc;
        private Label signedInAsLbl;
        private Label descriptionLbl;
    }
}
