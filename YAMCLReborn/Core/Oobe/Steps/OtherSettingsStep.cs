using YAMCLReborn.Core.Config;

namespace YAMCLReborn.Core.Oobe.Steps
{
    public class OtherSettingsStep : OobeStep
    {
        public override string WindowTitle { get; } = "Other settings";
        public string? JavaPath { get; set; } = ConfigManager.CurrentConfig.JavaPath;
        public bool ShowConsole { get; set; }
        public bool LogToFile { get; set; } = true;

        public override void OnNextClicked()
        {
            ConfigManager.CurrentConfig.JavaPath = JavaPath;
            ConfigManager.CurrentConfig.ShowDebugWindow = ShowConsole;
            ConfigManager.CurrentConfig.LogToFile = LogToFile;
        }
    }
}
