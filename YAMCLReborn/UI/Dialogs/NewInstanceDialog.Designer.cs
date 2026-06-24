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
            loaderVerLbl = new Label();
            loaderVerBox = new TextBox();
            createBtn = new Button();
            cancelBtn = new Button();
            loaderLbl = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(12, 9);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(45, 17);
            nameLbl.TabIndex = 0;
            nameLbl.Text = "Name:";
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
            loaderKindBox.Location = new Point(97, 285);
            loaderKindBox.Name = "loaderKindBox";
            loaderKindBox.Size = new Size(691, 25);
            loaderKindBox.TabIndex = 4;
            // 
            // loaderVerLbl
            // 
            loaderVerLbl.AutoSize = true;
            loaderVerLbl.Location = new Point(12, 313);
            loaderVerLbl.Name = "loaderVerLbl";
            loaderVerLbl.Size = new Size(96, 17);
            loaderVerLbl.TabIndex = 7;
            loaderVerLbl.Text = "Loader Version:";
            // 
            // loaderVerBox
            // 
            loaderVerBox.Location = new Point(114, 313);
            loaderVerBox.Name = "loaderVerBox";
            loaderVerBox.Size = new Size(674, 22);
            loaderVerBox.TabIndex = 8;
            // 
            // createBtn
            // 
            createBtn.Location = new Point(713, 353);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(75, 23);
            createBtn.TabIndex = 9;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += CreateBtnClicked;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(12, 353);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 10;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += CancelBtnClicked;
            // 
            // loaderLbl
            // 
            loaderLbl.AutoSize = true;
            loaderLbl.Location = new Point(12, 288);
            loaderLbl.Name = "loaderLbl";
            loaderLbl.Size = new Size(79, 17);
            loaderLbl.TabIndex = 5;
            loaderLbl.Text = "Mod Loader:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 336);
            label1.Name = "label1";
            label1.Size = new Size(123, 16);
            label1.TabIndex = 11;
            label1.Text = "(leave blank for latest)";
            // 
            // NewInstanceDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 388);
            Controls.Add(label1);
            Controls.Add(cancelBtn);
            Controls.Add(createBtn);
            Controls.Add(loaderVerBox);
            Controls.Add(loaderVerLbl);
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
        private Label loaderVerLbl;
        private TextBox loaderVerBox;
        private Button createBtn;
        private Button cancelBtn;
        private Label loaderLbl;
        private Label label1;
    }
}