using System;
using System.Runtime.InteropServices;
using CoreGraphics;
using Foundation;
using UIKit;

namespace CGRectIssue
{
	[Register ("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		public override UIWindow Window {
			get;
			set;
		}

		[DllImport ("/System/Library/Frameworks/CoreGraphics.framework/CoreGraphics")]
		static extern CGRect CGRectIntersection (CGRect left, CGRect right);

		public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{
			// Two disjoint rects
			var r1 = new CGRect (50, 50, 10, 10);
			var r2 = new CGRect (100, 100, 10, 10);

			// This condradicts with Apple's doc – https://developer.apple.com/reference/coregraphics/cgrectnull
			// The null rectangle. This is the rectangle returned when, for example, you intersect two disjoint rectangles.
			// Note that the null rectangle is not the same as the zero rectangle. 
			// For example, the union of a rectangle with the null rectangle is the original rectangle (that is, the null rectangle contributes nothing).
			var tmp = r1;
			tmp.Intersect (r2); // this is mutable method
			Console.WriteLine (tmp.IsNull ()); // Expected true, but result is false

			tmp = CGRectIntersection (r1, r2);
			Console.WriteLine (tmp.IsNull ()); // Expected true, actual true

			// This should be CGRectNull
			var rectNull = new CGRect (nfloat.PositiveInfinity, nfloat.PositiveInfinity, 0, 0);
			Console.WriteLine (rectNull.IsNull ());  // Expected true, actual true

			// CGRectEmpty and CGRectNull are different
			var union1 = r1.UnionWith (CGRect.Empty); // new rect {0, 0, 60, 60}
			Console.WriteLine (union1);
			var union2 = r1.UnionWith (rectNull);     // r1
			Console.WriteLine (union2);

			return true;
		}
	}
}

