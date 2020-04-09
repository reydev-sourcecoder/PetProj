// reference https://montemagno.com/setting-android-status-bar-background-icon-colors/
using Android.OS;
using CustomFontDemo.Themes;
using System.Drawing;
using Xamarin.Essentials;
using XF = Xamarin.Forms;

[assembly: XF.Dependency(typeof(CustomFontDemo.Droid.AndroidThemeService))]
namespace CustomFontDemo.Droid
{
    public class AndroidThemeService : IPlatformThemeService
    {
        public void SwitchTheme(bool isDarkMode)
        {
            if (isDarkMode)
                SetStatusBarColor(Color.Black, false);
            else
                SetStatusBarColor(ColorConverters.FromHex("#1976D2"), false);
        }

        private void SetStatusBarColor(Color color, bool darkStatusBarTint)
        {
            if (Build.VERSION.SdkInt < BuildVersionCodes.Lollipop)
                return;

            var activity = Plugin.CurrentActivity.CrossCurrentActivity.Current.Activity;
            var window = activity.Window;
            window.AddFlags(Android.Views.WindowManagerFlags.DrawsSystemBarBackgrounds);
            window.ClearFlags(Android.Views.WindowManagerFlags.TranslucentStatus);
            window.SetStatusBarColor(color.ToPlatformColor());

            if (Build.VERSION.SdkInt >= BuildVersionCodes.M)
            {
                var flag = (Android.Views.StatusBarVisibility)Android.Views.SystemUiFlags.LightStatusBar;
                window.DecorView.SystemUiVisibility = darkStatusBarTint ? flag : 0;
            }
        }
    }
}