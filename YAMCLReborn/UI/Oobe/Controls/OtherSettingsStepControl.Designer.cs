namespace YAMCLReborn.UI.Oobe.Controls
{
    partial class OtherSettingsStepControl
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
            welcomeLbl = new Label();
            descriptionLbl = new Label();
            javaPathBox = new TextBox();
            javaPathLbl = new Label();
            browseJavaBtn = new Button();
            mainLayoutPanel = new TableLayoutPanel();
            showConsoleChk = new CheckBox();
            logToFileChk = new CheckBox();
            mainLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // welcomeLbl
            // 
            welcomeLbl.AutoSize = true;
            welcomeLbl.Font = new Font("Inter", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLbl.Location = new Point(0, 0);
            welcomeLbl.Name = "welcomeLbl";
            welcomeLbl.Size = new Size(162, 30);
            welcomeLbl.TabIndex = 0;
            welcomeLbl.Text = "Other settings";
            // 
            // descriptionLbl
            // 
            descriptionLbl.AutoSize = true;
            descriptionLbl.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionLbl.Location = new Point(6, 30);
            descriptionLbl.Name = "descriptionLbl";
            descriptionLbl.Size = new Size(163, 17);
            descriptionLbl.TabIndex = 2;
            descriptionLbl.Text = "You can change these later.";
            // 
            // javaPathBox
            // 
            javaPathBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            javaPathBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            javaPathBox.AutoCompleteSource = AutoCompleteSource.FileSystem;
            javaPathBox.Location = new Point(98, 133);
            javaPathBox.Name = "javaPathBox";
            javaPathBox.Size = new Size(489, 22);
            javaPathBox.TabIndex = 4;
            // 
            // javaPathLbl
            // 
            javaPathLbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            javaPathLbl.AutoSize = true;
            javaPathLbl.Location = new Point(3, 136);
            javaPathLbl.Name = "javaPathLbl";
            javaPathLbl.Size = new Size(89, 17);
            javaPathLbl.TabIndex = 3;
            javaPathLbl.Text = "Java path:";
            javaPathLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // browseJavaBtn
            // 
            browseJavaBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            browseJavaBtn.Location = new Point(593, 131);
            browseJavaBtn.Name = "browseJavaBtn";
            browseJavaBtn.Size = new Size(95, 27);
            browseJavaBtn.TabIndex = 5;
            browseJavaBtn.Text = "Browse";
            browseJavaBtn.UseVisualStyleBackColor = true;
            browseJavaBtn.Click += BrowseJavaBtnClicked;
            // 
            // mainLayoutPanel
            // 
            mainLayoutPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainLayoutPanel.ColumnCount = 3;
            mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.7681112F));
            mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.73913F));
            mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.4927549F));
            mainLayoutPanel.Controls.Add(browseJavaBtn, 2, 0);
            mainLayoutPanel.Controls.Add(javaPathLbl, 0, 0);
            mainLayoutPanel.Controls.Add(javaPathBox, 1, 0);
            mainLayoutPanel.Location = new Point(6, 50);
            mainLayoutPanel.Name = "mainLayoutPanel";
            mainLayoutPanel.RowCount = 1;
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainLayoutPanel.Size = new Size(691, 289);
            mainLayoutPanel.TabIndex = 3;
            // 
            // showConsoleChk
            // 
            showConsoleChk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            showConsoleChk.AutoSize = true;
            showConsoleChk.Location = new Point(9, 372);
            showConsoleChk.Name = "showConsoleChk";
            showConsoleChk.Size = new Size(153, 21);
            showConsoleChk.TabIndex = 4;
            showConsoleChk.Text = "Show console window";
            showConsoleChk.UseVisualStyleBackColor = true;
            showConsoleChk.CheckedChanged += ShowConsoleChkChanged;
            // 
            // logToFileChk
            // 
            logToFileChk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            logToFileChk.AutoSize = true;
            logToFileChk.Location = new Point(9, 345);
            logToFileChk.Name = "logToFileChk";
            logToFileChk.Size = new Size(92, 21);
            logToFileChk.TabIndex = 5;
            logToFileChk.Text = "Log to a file";
            logToFileChk.UseVisualStyleBackColor = true;
            logToFileChk.CheckedChanged += LogToFileChkChanged;
            // 
            // OtherSettingsStepControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(logToFileChk);
            Controls.Add(showConsoleChk);
            Controls.Add(mainLayoutPanel);
            Controls.Add(descriptionLbl);
            Controls.Add(welcomeLbl);
            Name = "OtherSettingsStepControl";
            Size = new Size(700, 400);
            mainLayoutPanel.ResumeLayout(false);
            mainLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeLbl;
        private Label descriptionLbl;
        private TextBox javaPathBox;
        private Label javaPathLbl;
        private Button browseJavaBtn;
        private TableLayoutPanel mainLayoutPanel;
        private CheckBox showConsoleChk;
        private CheckBox logToFileChk;
    }
}
