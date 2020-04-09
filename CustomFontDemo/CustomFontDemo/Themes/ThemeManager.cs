using Xamarin.Forms;

namespace CustomFontDemo.Themes
{
    public class ThemeManager
    {
        public static void SetTheme(bool isDarkMode)
        {
            ITheme theme;

            if (isDarkMode)
                theme = new DarkTheme();
            else
                theme = new LightTheme();

            DependencyService.Get<IPlatformThemeService>().SwitchTheme(isDarkMode);
            theme.SetAsTheme();
        }
    }
}
