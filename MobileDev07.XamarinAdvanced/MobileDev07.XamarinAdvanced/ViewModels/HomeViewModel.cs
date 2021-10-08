using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using MobileDev07.XamarinAdvanced.Services;
using System.Windows.Input;
using Prism.Commands;
using Xamarin.Forms;

namespace MobileDev07.XamarinAdvanced.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public string DeviceOrientation { get; set; }
        public HomeViewModel(INavigationService navigationService) : base(navigationService)
        {
            GetDeviceOrientationCommand = new DelegateCommand<string>((text) =>
            {
                DeviceOrientation = DependencyService.Get<IDeviceOrientationService>().GetDeviceOrientation().ToString();
            });
        }

        public ICommand GetDeviceOrientationCommand { get; }
    }
}
