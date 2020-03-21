using Prism.Navigation;
using ReyTools.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ReyTools.ViewModels
{
    public class DashboardPageViewModel : BaseViewModel
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

        public DashboardPageViewModel(INavigationService navigationService) : base(navigationService)
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
        }

        private void NavigateToMainPage(MasterMenuItem menuItem)
            => ChangeMasterDetailToPage(menuItem.PageName);

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
