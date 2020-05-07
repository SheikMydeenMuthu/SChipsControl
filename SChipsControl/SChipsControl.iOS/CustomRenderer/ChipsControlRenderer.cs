using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace SChipsControl.iOS.CustomRenderer
{
    public class ChipsControlRenderer:EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control == null)
                return;
            Control.BackgroundColor = UIColor.Blue;
            Control.BorderStyle = UITextBorderStyle.Line;
        }
    }
}