using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace MobileDev07.XamarinAdvanced.Services
{
    public interface IDeviceOrientationService
    {
        DeviceOrientation GetDeviceOrientation();
    }
}
