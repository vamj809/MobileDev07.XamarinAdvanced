using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileDev07.XamarinAdvanced.Views;

namespace MobileDev07.XamarinAdvanced
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
