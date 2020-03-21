using Prism.Navigation;
using ReyTools.Data;
using System.Collections.ObjectModel;
using System.Linq;

namespace ReyTools.ViewModels
{
    public class PhonePrefixesPageViewModel : ViewModelBase
    {

        private ObservableCollection<MobilePrefix> _mobilePrefixes;
        public ObservableCollection<MobilePrefix> MobilePrefixes
        {
            get { return _mobilePrefixes; }
            set { _mobilePrefixes = value; RaisePropertyChanged(); }
        }

        private ObservableCollection<MobilePrefix> _filteredMobilePrefixes;
        public ObservableCollection<MobilePrefix> FilteredMobilePrefixes
        {
            get { return _filteredMobilePrefixes; }
            set { _filteredMobilePrefixes = value; RaisePropertyChanged(); }
        }

        private string _prefixKey;
        public string PrefixKey
        {
            get { return _prefixKey; }
            set 
            { 
                _prefixKey = value;
                RaisePropertyChanged();
                FilterMobilePrefixes(value);
            }
        }


        public PhonePrefixesPageViewModel(INavigationService navigationService) : base(navigationService) { }

        public override void InitializePageBinding(INavigationParameters parameters)
        {
            MobilePrefixes = new ObservableCollection<MobilePrefix>(FakeData.MobilePrefixes);
            FilteredMobilePrefixes = new ObservableCollection<MobilePrefix>(MobilePrefixes);
        }

        private void FilterMobilePrefixes(string key)
        {
            if (string.IsNullOrEmpty(key))
                FilteredMobilePrefixes = MobilePrefixes;
            else
                FilteredMobilePrefixes = new ObservableCollection<MobilePrefix>(MobilePrefixes.Where(p => p.Prefix.Contains(key)));
        }
    }
}
