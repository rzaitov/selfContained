using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace LessOrEqual
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		readonly nuint min = 10000000;
		readonly nuint max = 40000000;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			bool flag1 = min < max;
			bool flag2 = min <= max;
			bool flag3 = min > max;
			bool flag4 = min >= max;

			Console.WriteLine ("min < max | {0} < {1} == {2}", min, max, flag1);
			Console.WriteLine ("min <= max | {0} <= {1} == {2}", min, max, flag2);
			Console.WriteLine ("min > max | {0} > {1} == {2}", min, max, flag3);
			Console.WriteLine ("min >= max | {0} >= {1} == {2}", min, max, flag4);
			return true;
		}
	}
}

