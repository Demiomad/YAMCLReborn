namespace YAMCLReborn.UI.Dialogs
{
    partial class NewInstanceDialog
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
            nameLbl = new Label();
            instanceNameBox = new TextBox();
            versionListBox = new ListBox();
            gameVerLbl = new Label();
            loaderKindBox = new ComboBox();
            loaderLbl = new Label();
            loaderKindLbl = new Label();
            loaderVerLbl = new Label();
            loaderVerBox = new TextBox();
            createBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(12, 9);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(96, 17);
            nameLbl.TabIndex = 0;
            nameLbl.Text = "Instance Name:";
            // 
            // instanceNameBox
            // 
            instanceNameBox.Location = new Point(12, 29);
            instanceNameBox.Name = "instanceNameBox";
            instanceNameBox.Size = new Size(776, 22);
            instanceNameBox.TabIndex = 1;
            // 
            // versionListBox
            // 
            versionListBox.FormattingEnabled = true;
            versionListBox.Location = new Point(12, 74);
            versionListBox.Name = "versionListBox";
            versionListBox.Size = new Size(776, 208);
            versionListBox.TabIndex = 2;
            // 
            // gameVerLbl
            // 
            gameVerLbl.AutoSize = true;
            gameVerLbl.Location = new Point(12, 54);
            gameVerLbl.Name = "gameVerLbl";
            gameVerLbl.Size = new Size(90, 17);
            gameVerLbl.TabIndex = 3;
            gameVerLbl.Text = "Game Version:";
            // 
            // loaderKindBox
            // 
            loaderKindBox.FormattingEnabled = true;
            loaderKindBox.Location = new Point(54, 305);
            loaderKindBox.Name = "loaderKindBox";
            loaderKindBox.Size = new Size(734, 25);
            loaderKindBox.TabIndex = 4;
            // 
            // loaderLbl
            // 
            loaderLbl.AutoSize = true;
            loaderLbl.Location = new Point(12, 285);
            loaderLbl.Name = "loaderLbl";
            loaderLbl.Size = new Size(79, 17);
            loaderLbl.TabIndex = 5;
            loaderLbl.Text = "Mod Loader:";
            // 
            // loaderKindLbl
            // 
            loaderKindLbl.AutoSize = true;
            loaderKindLbl.Location = new Point(12, 308);
            loaderKindLbl.Name = "loaderKindLbl";
            loaderKindLbl.Size = new Size(36, 17);
            loaderKindLbl.TabIndex = 6;
            loaderKindLbl.Text = "Kind:";
            // 
            // loaderVerLbl
            // 
            loaderVerLbl.AutoSize = true;
            loaderVerLbl.Location = new Point(12, 335);
            loaderVerLbl.Name = "loaderVerLbl";
            loaderVerLbl.Size = new Size(182, 17);
            loaderVerLbl.TabIndex = 7;
            loaderVerLbl.Text = "Version (leave blank for latest):";
            // 
            // loaderVerBox
            // 
            loaderVerBox.Location = new Point(200, 332);
            loaderVerBox.Name = "loaderVerBox";
            loaderVerBox.Size = new Size(588, 22);
            loaderVerBox.TabIndex = 8;
            // 
            // createBtn
            // 
            createBtn.Location = new Point(713, 396);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(75, 23);
            createBtn.TabIndex = 9;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += CreateBtnClicked;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(16, 396);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 10;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += CancelBtnClicked;
            // 
            // NewInstanceDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 431);
            Controls.Add(cancelBtn);
            Controls.Add(createBtn);
            Controls.Add(loaderVerBox);
            Controls.Add(loaderVerLbl);
            Controls.Add(loaderKindLbl);
            Controls.Add(loaderLbl);
            Controls.Add(loaderKindBox);
            Controls.Add(gameVerLbl);
            Controls.Add(versionListBox);
            Controls.Add(instanceNameBox);
            Controls.Add(nameLbl);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewInstanceDialog";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "New Instance";
            Load += NewInstanceDialogLoaded;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLbl;
        private TextBox instanceNameBox;
        private ListBox versionListBox;
        private Label gameVerLbl;
        private ComboBox loaderKindBox;
        private Label loaderLbl;
        private Label loaderKindLbl;
        private Label loaderVerLbl;
        private TextBox loaderVerBox;
        private Button createBtn;
        private Button cancelBtn;
    }
}