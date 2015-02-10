using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace UndoManager
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		UIWindow window;
		MainController controller;
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			controller = new MainController ();

			window = new UIWindow (UIScreen.MainScreen.Bounds);
			window.RootViewController = controller;
			window.MakeKeyAndVisible ();

			return true;
		}
	}
}

