using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileDev07.XamarinAdvanced.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AndroidNavigationPage : NavigationPage
    {
        public AndroidNavigationPage()
        {
            InitializeComponent();
        }
    }
}