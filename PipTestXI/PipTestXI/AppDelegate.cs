using Foundation;
using UIKit;
using System;

using AVKit;
using AVFoundation;

namespace PipTestXI
{
	[Register ("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		public override UIWindow Window {
			get;
			set;
		}

		public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{
			Console.WriteLine ("IsPictureInPictureSupported {0}", AVPictureInPictureController.IsPictureInPictureSupported);
			return true;
		}
	}
}