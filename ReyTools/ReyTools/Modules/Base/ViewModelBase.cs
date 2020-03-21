using Prism.Mvvm;
using Prism.Navigation;

namespace ReyTools.ViewModels
{
    public abstract class ViewModelBase : BindableBase, INavigationAware, IInitialize
    {
        protected readonly INavigationService NavigationService;

        protected ViewModelBase(INavigationService navigationService) => NavigationService = navigationService;

        public void Initialize(INavigationParameters parameters) => InitializePageBinding(parameters);

        public void OnNavigatedFrom(INavigationParameters parameters) { }

        public void OnNavigatedTo(INavigationParameters parameters) { }

        protected async void ChangeMasterDetailToPage(string pageName) 
            => await NavigationService.NavigateAsync($"{nameof(PageNames.NavigationPage)}/{pageName}");

        public abstract void InitializePageBinding(INavigationParameters parameters);
    }
}
