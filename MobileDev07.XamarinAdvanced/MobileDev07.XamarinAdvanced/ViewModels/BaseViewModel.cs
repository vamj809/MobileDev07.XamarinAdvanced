using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MobileDev07.XamarinAdvanced.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        INavigationService _navigationService;
        public BaseViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
