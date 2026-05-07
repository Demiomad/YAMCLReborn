using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using YAMCLReborn.Core.Oobe.Steps;

namespace YAMCLReborn.UI.Oobe.Controls
{
    public partial class WelcomeStepControl : UserControl
    {
        private WelcomeStep _step;

        public WelcomeStepControl(WelcomeStep step)
        {
            InitializeComponent();

            _step = step;
            _step.CanContinue = true;
        }
    }
}
