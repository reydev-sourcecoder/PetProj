using System;
using Xamarin.Forms.Xaml;

namespace ReyTools.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PhonePrefixesPage : BasePage
    {
        public PhonePrefixesPage()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                // TODO : Log here
            }
        }
    }
}