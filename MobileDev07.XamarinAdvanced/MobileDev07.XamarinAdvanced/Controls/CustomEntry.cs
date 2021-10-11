using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobileDev07.XamarinAdvanced.Controls
{
    public class CustomEntry : Entry
    {
        public static readonly BindableProperty HasColorProperty =
  BindableProperty.Create(nameof(HasColor), typeof(bool), typeof(CustomEntry), false, BindingMode.TwoWay);

        public bool HasColor
        {
            get { return (bool)GetValue(HasColorProperty); }
            set
            {
                SetValue(HasColorProperty, value);
            }
        }
    }
}
