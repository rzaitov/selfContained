using System;

using UIKit;

namespace TabbarImageIssue
{
	public partial class SecondViewController : UIViewController
	{
		public SecondViewController (IntPtr handle) : base (handle)
		{
			// This doesn't work, but should work
//			TabBarItem.Title = "Second";
//			TabBarItem.Image = UIImage.FromBundle ("tabIconPoints");
//			TabBarItem.SelectedImage = UIImage.FromBundle ("tabIconPoints");

			// This doesn't work, but should work
			TabBarItem = new UITabBarItem (
				"Second",
				UIImage.FromBundle ("tabIconPoints"),
				UIImage.FromBundle ("tabIconPoints")
			);
		}
	}
}

