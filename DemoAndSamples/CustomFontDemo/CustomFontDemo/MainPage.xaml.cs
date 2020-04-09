using CustomFontDemo.Themes;
using System.ComponentModel;
using Xamarin.Forms;

namespace CustomFontDemo
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage() => InitializeComponent();

        private void Switch_Toggled(object sender, ToggledEventArgs e) 
            => ThemeManager.SetTheme(e.Value);
    }
}
