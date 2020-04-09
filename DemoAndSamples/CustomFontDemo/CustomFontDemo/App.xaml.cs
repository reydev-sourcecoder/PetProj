// more reference : https://medium.com/@milan.gohil/adding-themes-to-your-xamarin-forms-app-3da3032cc3a1
using Xamarin.Forms;

namespace CustomFontDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart() { }

        protected override void OnSleep() { }

        protected override void OnResume() { }
    }
}
