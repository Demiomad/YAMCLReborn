namespace YAMCLReborn.UI.Oobe.Controls
{
    partial class WelcomeStepControl
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
            SuspendLayout();
            // 
            // welcomeLbl
            // 
            welcomeLbl.AutoSize = true;
            welcomeLbl.Font = new Font("Inter", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLbl.Location = new Point(0, 0);
            welcomeLbl.Name = "welcomeLbl";
            welcomeLbl.Size = new Size(312, 30);
            welcomeLbl.TabIndex = 0;
            welcomeLbl.Text = "Welcome to YAMCL: Reborn!";
            // 
            // descriptionLbl
            // 
            descriptionLbl.AutoSize = true;
            descriptionLbl.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionLbl.Location = new Point(3, 30);
            descriptionLbl.Name = "descriptionLbl";
            descriptionLbl.Size = new Size(402, 34);
            descriptionLbl.TabIndex = 1;
            descriptionLbl.Text = "This wizard will help you configure YAMCL: Reborn to your own liking.\r\nTo proceed, press \"Next\". Otherwise, close this window to exit.";
            // 
            // WelcomeStepControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(descriptionLbl);
            Controls.Add(welcomeLbl);
            Name = "WelcomeStepControl";
            Size = new Size(700, 400);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeLbl;
        private Label descriptionLbl;
    }
}
