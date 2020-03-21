using Prism;
using Prism.Ioc;
using Prism.Unity;
using ReyTools.ViewModels;
using ReyTools.Views;
using System;
using Unity;
using Unity.Lifetime;
using Xamarin.Forms;

namespace ReyTools
{
    public partial class App : PrismApplication
    {
        private IUnityContainer _unityContainer;

        public App(IPlatformInitializer platformInitializer = null) : base(platformInitializer) {  }

        protected override void OnInitialized()
        {
            try
            {
                InitializeComponent();

                _unityContainer = Container.GetContainer();
                _unityContainer.RegisterInstance(NavigationService, new ContainerControlledLifetimeManager());

                SetMasterPageAndNavigateToPage(nameof(PageNames.PhonePrefixesPage));
            }
            catch (Exception ex)
            {
                // TODO : log here
            }
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<DashboardPage>();
            containerRegistry.RegisterForNavigation<PhonePrefixesPage>();
            containerRegistry.RegisterForNavigation<ZipCodesPage>();
        }

        private void SetMasterPageAndNavigateToPage(string pageName)
            => NavigationService.NavigateAsync($"{nameof(DashboardPage)}/{nameof(NavigationPage)}/{pageName}");

        protected override void OnStart() { }

        protected override void OnSleep() { }

        protected override void OnResume() { }
    }
}
