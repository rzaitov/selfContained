using System;
using System.Drawing;

using CoreGraphics;
using Foundation;
using UIKit;

namespace XibSupport
{
    [Register("CustomUIView")]
    public class CustomUIView : UIView
    {
        public CustomUIView()
        {
            Initialize();
        }

        public CustomUIView(RectangleF bounds)
            : base(bounds)
        {
            Initialize();
        }

        void Initialize()
        {
            BackgroundColor = UIColor.Red;
        }
    }
}