using Prism.Navigation;

namespace ReyTools.ViewModels
{
    public class ZipCodesPageViewModel : ViewModelBase
    {
        public ZipCodesPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        /// <summary>
        /// This would be the implementation of Initialize(INavigationParameters parameters)
        /// in the ViewModelBase
        /// </summary>
        /// <param name="parameters">The parameters that are being passed between pages</param>
        public override void InitializePageBinding(INavigationParameters parameters)
        {
           
        }
    }
}
