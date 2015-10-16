using System;

using UIKit;
using Foundation;

namespace CustomCell
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

//			NSArray nib = NSBundle.MainBundle.LoadNib ("CuteCell", this, null);
//			var cell = nib.GetItem<UITableViewCell> (0);
//			View.AddSubview (cell);

			NSArray nib = NSBundle.MainBundle.LoadNib ("CuteView", this, null);
			var view = nib.GetItem<UIView> (0);
			View.AddSubview (view);
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

