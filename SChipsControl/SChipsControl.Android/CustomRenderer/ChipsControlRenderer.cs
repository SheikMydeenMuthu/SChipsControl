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

[assembly:ExportRenderer(typeof(ChipsControl),typeof(ChipsControlRenderer))]
namespace SChipsControl.Droid.CustomRenderer
{
    public class ChipsControlRenderer//:FlexLayoutRenderer
    {
    }
}