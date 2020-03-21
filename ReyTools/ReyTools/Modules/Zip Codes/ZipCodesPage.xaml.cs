using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReyTools.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ZipCodesPage : BasePage
    {
        public ZipCodesPage()
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