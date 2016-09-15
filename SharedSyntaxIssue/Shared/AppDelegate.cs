using System;
using Foundation;

using UIKit;

namespace Shared
{
	[Register ("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		public override UIWindow Window { get; set; }

		public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{
			#if __IOS__
			Console.WriteLine ("this is iOS");
			#elif __TVOS__
			Console.WriteLine ("this is tvOS");
			#endif
			return true;
		}
	}
}

