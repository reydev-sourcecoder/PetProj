using Prism.Navigation;

namespace ReyTools.ViewModels
{
    public abstract class BaseViewModel
    {
        protected readonly INavigationService NavigationService;

        public BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        protected async void ChangeMasterDetailToPage(string pageName) 
            => await NavigationService.NavigateAsync($"{nameof(PageNames.NavigationPage)}/{pageName}");
    }
}
