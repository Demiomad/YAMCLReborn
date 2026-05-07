namespace YAMCLReborn.Core.Oobe.Steps
{
    public class AccountStep : OobeStep
    {
        public override string WindowTitle { get; } = "Set up your account";

        /// <summary>
        /// Called whenever the user signs in.
        /// </summary>
        public void OnSignedIn()
        {
            CanContinue = true;
            RaiseOnCanContinueChanged();
        }
    }
}
