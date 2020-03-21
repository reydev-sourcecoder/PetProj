using Prism.Navigation;
using ReyTools.Data;
using System.Collections.ObjectModel;

namespace ReyTools.ViewModels
{
    public class PhonePrefixesPageViewModel : ViewModelBase
    {
        public ObservableCollection<MobilePrefix> MobilePrefixes { get; set; }

        public PhonePrefixesPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            
        }

        public override void InitializePageBinding(INavigationParameters parameters)
        {
            MobilePrefixes = new ObservableCollection<MobilePrefix>(FakeData.MobilePrefixes);
        }
    }
}
