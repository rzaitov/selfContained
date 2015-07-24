using System;
using UIKit;
using Foundation;

namespace NSStringEqualsOp
{
	public class MainVC : UIViewController
	{
		public MainVC ()
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

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

		}
	}
}

