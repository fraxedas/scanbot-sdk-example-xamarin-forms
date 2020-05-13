﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ScanbotSDK.Xamarin.Forms;
using Xamarin.Forms;

namespace Scanbot.SDK.Example.Forms
{
    public class ImageResultCell : ViewCell
    {
        public IScannedPage Source { get; private set; }

        Image Document { get; set; }

        public ImageResultCell()
        {
            Document = new Image();
            Document.Margin = new Thickness(10, 10, 10, 10);

            View = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { Document  }
            };
        }

        protected override void OnBindingContextChanged()
        {
            if (BindingContext == null)
            {
                return;
            }
            Source = (IScannedPage)BindingContext;
            Document.Source = Source.Document;

            base.OnBindingContextChanged();
        }

    }
}
