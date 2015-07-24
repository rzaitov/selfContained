using System;

using Foundation;
using UIKit;

namespace NSStringEqualsOp
{
	[Register ("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		public override UIWindow Window {
			get;
			set;
		}

		UIViewController mainVC;
		public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{
			Window = new UIWindow (UIScreen.MainScreen.Bounds);
			Window.MakeKeyAndVisible ();

			NSString a = new NSString ("a");
			NSString b = new NSString ("b");

			try {
				if(a == b)
					Console.WriteLine ("Equal");
				else
					Console.WriteLine ("not Equal");
			} catch (Exception e) {
				Console.WriteLine (e);
			}

			return true;
		}
	}
}