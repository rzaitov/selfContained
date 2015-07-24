using System;

using UIKit;
using Foundation;

namespace NSArrayTest
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			NSArray nib = NSBundle.MainBundle.LoadNib ("XibCollection", this, null);
			UIView v = nib.GetItem<UIView> (0);
			UIViewController vc = nib.GetItem<UIViewController> (1);
			Console.WriteLine ("{0} {1}", vc.Description, vc.GetType());
			Console.WriteLine ("{0} {1}", v.Description, v.GetType());

			// Here I will get expected behaviour – an exception
			NSArray arr = NSArray.FromNSObjects (new UIView (), new UIViewController ());
			UIViewController viewController = arr.GetItem<UIViewController> (0);
			UIView view = arr.GetItem<UIView> (1);

			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

