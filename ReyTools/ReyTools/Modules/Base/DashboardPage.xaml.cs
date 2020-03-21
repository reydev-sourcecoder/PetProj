using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReyTools.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardPage : MasterDetailPage
    {
        public DashboardPage()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
               
            }
        }
    }
}