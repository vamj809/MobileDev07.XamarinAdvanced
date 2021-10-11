using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MobileDev07.XamarinAdvanced.Controls;
using MobileDev07.XamarinAdvanced.Droid.Renderers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace MobileDev07.XamarinAdvanced.Droid.Renderers
{
    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            Control.SetBackgroundColor(Android.Graphics.Color.PaleTurquoise);
        }
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            var customEntry = Element as CustomEntry;

            if(e.PropertyName == CustomEntry.HasColorProperty.PropertyName)
            {
                Control.SetBackgroundColor(customEntry.HasColor ? Android.Graphics.Color.PaleTurquoise : Android.Graphics.Color.White);
            }
        }
    }
}