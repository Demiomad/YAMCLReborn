using System;
using System.Collections.Generic;
using System.Text;

namespace YAMCLReborn.Core.Oobe
{
    /// <summary>
    /// Represents a step for the OOBE.
    /// </summary>
    public abstract class OobeStep
    {
        /// <summary>
        /// The window title.
        /// </summary>
        public abstract string WindowTitle { get; }

        /// <summary>
        /// Whether the user can continue this step.
        /// </summary>
        public virtual bool CanContinue { get; set; }

        /// <summary>
        /// The event that gets raised when the <see cref="CanContinue"/>> property gets changed.
        /// </summary>
        public EventHandler? OnCanContinueChanged { get; set; }

        /// <summary>
        /// Raises the <see cref="OnCanContinueChanged"/> event.
        /// </summary>
        public void RaiseOnCanContinueChanged()
        {
            OnCanContinueChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Called when the Next button gets pressed.
        /// </summary>
        public virtual void OnNextClicked()
        {

        }
    }
}
