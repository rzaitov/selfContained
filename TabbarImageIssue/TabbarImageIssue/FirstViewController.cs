using System;

using UIKit;

namespace TabbarImageIssue
{
	public partial class FirstViewController : UIViewController
	{
		public FirstViewController (IntPtr handle) : base (handle)
		{
			TabBarItem.Title = "First";
			TabBarItem.Image = UIImage.FromBundle ("tabIconMessages");
		}

		public override void ViewDidLoad ()
		{
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

