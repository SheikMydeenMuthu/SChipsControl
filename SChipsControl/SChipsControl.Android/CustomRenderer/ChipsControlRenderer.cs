using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SChipsControl.CustomControls;
using SChipsControl.Droid.CustomRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(ChipsControl),typeof(ChipsControlRenderer))]
namespace SChipsControl.Droid.CustomRenderer
{
    public class ChipsControlRenderer:EntryRenderer
    {
        public ChipsControlRenderer(Context context):base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Entry> e)
        {
            base.OnElementChanged(e);
            if (Control == null)
                return;
            Control.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);

        }
    }
}