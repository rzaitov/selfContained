using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using CoreGraphics;

namespace NFloatProperty
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		UIWindow window;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			UIView v1 = new UIView ();
			v1.Frame = new CGRect (10, 20, 30, 40);
			var h = v1.Frame.Height;

			bool isequal = h == v1.Frame.Height;

			var v2 = new UIView ();
			v2.Frame = new CGRect (50, 60, 70, 80);

			NSLayoutConstraint constraint = NSLayoutConstraint.Create (v1, NSLayoutAttribute.Bottom, NSLayoutRelation.Equal, v2, NSLayoutAttribute.Bottom, 1, 10);
			var c1 = constraint.Constant;
			bool isequal1 = c1 == constraint.Constant;

			constraint.Constant = 777;
			var c2 = constraint.Constant;
			bool isequal2 = c2 == constraint.Constant;

			window = new UIWindow (UIScreen.MainScreen.Bounds);
			window.MakeKeyAndVisible ();
			return true;
		}
	}
}

