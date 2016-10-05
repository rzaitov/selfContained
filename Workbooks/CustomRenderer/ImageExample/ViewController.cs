using System;
using System.IO;
using AppKit;
using CoreGraphics;
using Foundation;
using ImageIO;
using MobileCoreServices;

namespace ImageExample
{
	public partial class ViewController : NSViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var w = 100;
			var h = 100;
			var componentNum = 4; // RGBA
			var bytesPerRow = w * componentNum;
			var bitsPerComponent = 8;
			var data = new byte [bytesPerRow * h];
			for (int x = 0; x < 100; x++) {
				for (int y = 0; y < 100; y++) {
					data [y * bytesPerRow + componentNum * x + 3] = 255;
				}
			}
			var provider = new CGDataProvider (data);
			var img = new CGImage (w, h, bitsPerComponent, bitsPerComponent * componentNum, bytesPerRow, CGColorSpace.CreateDeviceRGB (), CGBitmapFlags.Last, provider, null, false, CGColorRenderingIntent.Default);
			MyImage.Image = new NSImage (img, new CGSize (w, h));
		}
	}
}
