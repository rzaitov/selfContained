using System;

using UIKit;

namespace TabbarImageIssue
{
	public partial class FirstViewController : UIViewController
	{
		public FirstViewController (IntPtr handle) : base (handle)
		{
			// This doesn't work, but should work
			TabBarItem.Title = "First";
			TabBarItem.Image = UIImage.FromBundle ("tabIconMessages");
			TabBarItem.SelectedImage = UIImage.FromBundle ("tabIconMessages");

			// This doesn't work, but should work
//			TabBarItem = new UITabBarItem (
//				"First",
//				UIImage.FromBundle ("tabIconMessages"),
//				UIImage.FromBundle ("tabIconMessages")
//			);
		}
	}
}

