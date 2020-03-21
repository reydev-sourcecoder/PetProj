using Prism.Navigation;
using ReyTools.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ReyTools.ViewModels
{
    public class DashboardPageViewModel : ViewModelBase
    {
        public List<MasterMenuItem> MenuItems { get; set; }

        private MasterMenuItem _selectedMenuItem;
        public MasterMenuItem SelectedMenuItem
        {
            get { return _selectedMenuItem; }
            set
            {
                _selectedMenuItem = value;
                if (value != null)
                    NavigateToMainPage(_selectedMenuItem);
            }
        }

        public DashboardPageViewModel(INavigationService navigationService) : base(navigationService) { }

        public override void InitializePageBinding(INavigationParameters parameters)
        {
            InitializeMenuItems();
        }

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
