using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileDev07.XamarinAdvanced.Views;
using Prism.Unity;
using Prism.Ioc;
using Prism;
using MobileDev07.XamarinAdvanced.Helpers;
using MobileDev07.XamarinAdvanced.ViewModels;
using MobileDev07.XamarinAdvanced.Services;
using Prism.Navigation;

namespace MobileDev07.XamarinAdvanced
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<HomePage, HomeViewModel>();
            containerRegistry.Register<IDeviceOrientationService>();
        }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync($"{NavigationConstants.HomePage}");
        }
    }
}
