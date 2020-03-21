using Prism.Commands;
using Prism.Navigation;
using ReyTools.Models;
using System.Collections.Generic;
using System.Windows.Input;

namespace ReyTools.ViewModels
{
    public class DashboardPageViewModel : ViewModelBase
    {
        public ICommand NavigateToPageCommand => new DelegateCommand<MasterMenuItem>(NavigateToMainPage);
        public List<MasterMenuItem> MenuItems { get; set; }

        public DashboardPageViewModel(INavigationService navigationService) : base(navigationService) { }

        public override void InitializePageBinding(INavigationParameters parameters) => InitializeMenuItems();

        private void InitializeMenuItems()
        {
            MenuItems = new List<MasterMenuItem>
            {
                new MasterMenuItem
                {
                    Id = 1,
                    Title = nameof(PageNames.PhonePrefixesPage),
                    PageName = nameof(PageNames.PhonePrefixesPage)
                },
                new MasterMenuItem
                {
                    Id = 2,
                    Title = nameof(PageNames.ZipCodesPage),
                    PageName = nameof(PageNames.ZipCodesPage)
                }
            };

            RaisePropertyChanged(nameof(MenuItems));
        }

        private void NavigateToMainPage(MasterMenuItem menuItem)
            => ChangeMasterDetailToPage(menuItem.PageName);
    }
}
