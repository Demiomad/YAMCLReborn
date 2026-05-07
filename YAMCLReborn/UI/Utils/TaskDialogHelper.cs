using System;
using System.Collections.Generic;
using System.Text;

namespace YAMCLReborn.UI.Utils
{
    /// <summary>
    /// A helper for creating TaskDialogs.
    /// </summary>
    public static class TaskDialogHelper
    {
        /// <summary>
        /// Shows a task dialog.
        /// </summary>
        /// <param name="title">The text displayed in the title bar.</param>
        /// <param name="header">The big text.</param>
        /// <param name="content">The primary text.</param>
        /// <param name="icon">The dialog's icon.</param>
        /// <param name="buttons">The dialog's buttons.</param>
        /// <returns>The button the user clicked.</returns>
        public static TaskDialogButton ShowDialog(string title, string header, string content, TaskDialogIcon icon, params TaskDialogButton[] buttons)
        {
            var page = new TaskDialogPage()
            {
                Heading = header,
                Text = content,
                Caption = title,
                Icon = icon
            };

            foreach (var btn in buttons)
                page.Buttons.Add(btn);

            return TaskDialog.ShowDialog(page, TaskDialogStartupLocation.CenterScreen);
        }
    }
}
