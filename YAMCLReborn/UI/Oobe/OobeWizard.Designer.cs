namespace YAMCLReborn.UI.Oobe
{
    partial class OobeWizard
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
            nextBtn = new Button();
            contentPnl = new Panel();
            stepCountLbl = new Label();
            backBtn = new Button();
            SuspendLayout();
            // 
            // nextBtn
            // 
            nextBtn.Location = new Point(597, 427);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(75, 26);
            nextBtn.TabIndex = 0;
            nextBtn.Text = "Next >";
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.Click += NextBtnClicked;
            // 
            // contentPnl
            // 
            contentPnl.Dock = DockStyle.Top;
            contentPnl.Location = new Point(0, 0);
            contentPnl.Margin = new Padding(10);
            contentPnl.Name = "contentPnl";
            contentPnl.Padding = new Padding(5);
            contentPnl.Size = new Size(684, 418);
            contentPnl.TabIndex = 1;
            // 
            // stepCountLbl
            // 
            stepCountLbl.AutoSize = true;
            stepCountLbl.Location = new Point(12, 432);
            stepCountLbl.Name = "stepCountLbl";
            stepCountLbl.Size = new Size(57, 17);
            stepCountLbl.TabIndex = 2;
            stepCountLbl.Text = "Step 0/0";
            // 
            // backBtn
            // 
            backBtn.Location = new Point(516, 427);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(75, 26);
            backBtn.TabIndex = 3;
            backBtn.Text = "< Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += BackBtnClicked;
            // 
            // OobeWizard
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 461);
            Controls.Add(backBtn);
            Controls.Add(stepCountLbl);
            Controls.Add(contentPnl);
            Controls.Add(nextBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OobeWizard";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "YAMCL: Reborn Wizard";
            FormClosing += OobeWizardClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button nextBtn;
        private Panel contentPnl;
        private Label stepCountLbl;
        private Button backBtn;
    }
}