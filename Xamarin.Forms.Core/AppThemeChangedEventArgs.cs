using System;

namespace Xamarin.Forms
{
    public class AppThemeChangedEventArgs : EventArgs
    {
        public AppThemeChangedEventArgs(ApplicationTheme appTheme) =>
            RequestedTheme = appTheme;

        public ApplicationTheme RequestedTheme { get; }
    }
}