namespace YAMCLReborn
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            instanceListBox = new ListBox();
            menuStrip = new MenuStrip();
            instancesStrip = new ToolStripMenuItem();
            newStripBtn = new ToolStripMenuItem();
            tsSep1 = new ToolStripSeparator();
            refreshStripBtn = new ToolStripMenuItem();
            settingsStrip = new ToolStripMenuItem();
            rerunSetupStripBtn = new ToolStripMenuItem();
            instanceNameLbl = new Label();
            instanceVersionLbl = new Label();
            delInstanceBtn = new Button();
            instanceIcon = new PictureBox();
            editInstanceBtn = new Button();
            launchBtn = new Button();
            instanceModLoaderLbl = new Label();
            fileProgBar = new ProgressBar();
            byteProgBar = new ProgressBar();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)instanceIcon).BeginInit();
            SuspendLayout();
            // 
            // instanceListBox
            // 
            instanceListBox.BorderStyle = BorderStyle.FixedSingle;
            instanceListBox.Dock = DockStyle.Left;
            instanceListBox.Font = new Font("Inter", 9F);
            instanceListBox.FormattingEnabled = true;
            instanceListBox.Location = new Point(0, 25);
            instanceListBox.Name = "instanceListBox";
            instanceListBox.Size = new Size(387, 520);
            instanceListBox.TabIndex = 0;
            instanceListBox.SelectedValueChanged += InstanceListBoxSelectionChanged;
            // 
            // menuStrip
            // 
            menuStrip.Font = new Font("Inter", 9F);
            menuStrip.Items.AddRange(new ToolStripItem[] { instancesStrip, settingsStrip });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(793, 25);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // instancesStrip
            // 
            instancesStrip.DropDownItems.AddRange(new ToolStripItem[] { newStripBtn, tsSep1, refreshStripBtn });
            instancesStrip.Name = "instancesStrip";
            instancesStrip.Size = new Size(74, 21);
            instancesStrip.Text = "Instances";
            // 
            // newStripBtn
            // 
            newStripBtn.Name = "newStripBtn";
            newStripBtn.ShortcutKeys = Keys.Control | Keys.N;
            newStripBtn.Size = new Size(156, 22);
            newStripBtn.Text = "New...";
            newStripBtn.Click += NewStripBtnClicked;
            // 
            // tsSep1
            // 
            tsSep1.Name = "tsSep1";
            tsSep1.Size = new Size(153, 6);
            // 
            // refreshStripBtn
            // 
            refreshStripBtn.Name = "refreshStripBtn";
            refreshStripBtn.ShortcutKeys = Keys.F5;
            refreshStripBtn.Size = new Size(156, 22);
            refreshStripBtn.Text = "Refresh";
            refreshStripBtn.Click += RefreshStripBtnClicked;
            // 
            // settingsStrip
            // 
            settingsStrip.DropDownItems.AddRange(new ToolStripItem[] { rerunSetupStripBtn });
            settingsStrip.Name = "settingsStrip";
            settingsStrip.Size = new Size(66, 21);
            settingsStrip.Text = "Settings";
            // 
            // rerunSetupStripBtn
            // 
            rerunSetupStripBtn.Name = "rerunSetupStripBtn";
            rerunSetupStripBtn.Size = new Size(159, 22);
            rerunSetupStripBtn.Text = "Re-run setup...";
            rerunSetupStripBtn.Click += RerunSetupStripBtnClicked;
            // 
            // instanceNameLbl
            // 
            instanceNameLbl.AutoSize = true;
            instanceNameLbl.Font = new Font("Inter", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            instanceNameLbl.Location = new Point(391, 28);
            instanceNameLbl.Name = "instanceNameLbl";
            instanceNameLbl.Size = new Size(73, 30);
            instanceNameLbl.TabIndex = 2;
            instanceNameLbl.Text = "Name";
            // 
            // instanceVersionLbl
            // 
            instanceVersionLbl.AutoSize = true;
            instanceVersionLbl.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            instanceVersionLbl.Location = new Point(393, 55);
            instanceVersionLbl.Name = "instanceVersionLbl";
            instanceVersionLbl.Size = new Size(50, 17);
            instanceVersionLbl.TabIndex = 3;
            instanceVersionLbl.Text = "Version";
            // 
            // delInstanceBtn
            // 
            delInstanceBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            delInstanceBtn.Location = new Point(475, 448);
            delInstanceBtn.Name = "delInstanceBtn";
            delInstanceBtn.Size = new Size(75, 27);
            delInstanceBtn.TabIndex = 4;
            delInstanceBtn.Text = "Delete";
            delInstanceBtn.UseVisualStyleBackColor = true;
            delInstanceBtn.Click += DelInstanceBtnClicked;
            // 
            // instanceIcon
            // 
            instanceIcon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            instanceIcon.Location = new Point(717, 28);
            instanceIcon.Name = "instanceIcon";
            instanceIcon.Size = new Size(64, 64);
            instanceIcon.TabIndex = 5;
            instanceIcon.TabStop = false;
            // 
            // editInstanceBtn
            // 
            editInstanceBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            editInstanceBtn.Location = new Point(394, 448);
            editInstanceBtn.Name = "editInstanceBtn";
            editInstanceBtn.Size = new Size(75, 27);
            editInstanceBtn.TabIndex = 6;
            editInstanceBtn.Text = "Edit";
            editInstanceBtn.UseVisualStyleBackColor = true;
            editInstanceBtn.Click += EditInstanceBtnClicked;
            // 
            // launchBtn
            // 
            launchBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            launchBtn.Location = new Point(706, 448);
            launchBtn.Name = "launchBtn";
            launchBtn.Size = new Size(75, 27);
            launchBtn.TabIndex = 7;
            launchBtn.Text = "Launch";
            launchBtn.UseVisualStyleBackColor = true;
            launchBtn.Click += LaunchBtnClicked;
            // 
            // instanceModLoaderLbl
            // 
            instanceModLoaderLbl.AutoSize = true;
            instanceModLoaderLbl.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            instanceModLoaderLbl.Location = new Point(393, 75);
            instanceModLoaderLbl.Name = "instanceModLoaderLbl";
            instanceModLoaderLbl.Size = new Size(76, 17);
            instanceModLoaderLbl.TabIndex = 8;
            instanceModLoaderLbl.Text = "Mod Loader";
            // 
            // fileProgBar
            // 
            fileProgBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            fileProgBar.Location = new Point(394, 510);
            fileProgBar.Name = "fileProgBar";
            fileProgBar.Size = new Size(387, 23);
            fileProgBar.TabIndex = 9;
            // 
            // byteProgBar
            // 
            byteProgBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            byteProgBar.Location = new Point(394, 481);
            byteProgBar.Name = "byteProgBar";
            byteProgBar.Size = new Size(387, 23);
            byteProgBar.TabIndex = 10;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 545);
            Controls.Add(byteProgBar);
            Controls.Add(fileProgBar);
            Controls.Add(instanceModLoaderLbl);
            Controls.Add(launchBtn);
            Controls.Add(editInstanceBtn);
            Controls.Add(instanceIcon);
            Controls.Add(delInstanceBtn);
            Controls.Add(instanceVersionLbl);
            Controls.Add(instanceNameLbl);
            Controls.Add(instanceListBox);
            Controls.Add(menuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YAMCL: Reborn";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)instanceIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox instanceListBox;
        private MenuStrip menuStrip;
        private ToolStripMenuItem instancesStrip;
        private ToolStripMenuItem refreshStripBtn;
        private Label instanceNameLbl;
        private Label instanceVersionLbl;
        private Button delInstanceBtn;
        private PictureBox instanceIcon;
        private ToolStripMenuItem settingsStrip;
        private ToolStripMenuItem rerunSetupStripBtn;
        private Button editInstanceBtn;
        private ToolStripMenuItem newStripBtn;
        private ToolStripSeparator tsSep1;
        private Button launchBtn;
        private Label instanceModLoaderLbl;
        private ProgressBar fileProgBar;
        private ProgressBar byteProgBar;
    }
}
