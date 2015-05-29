using System;

using UIKit;

namespace TabbarImageIssue
{
	public partial class SecondViewController : UIViewController
	{
		public SecondViewController (IntPtr handle) : base (handle)
		{
			TabBarItem.Title = "Second";
			TabBarItem.Image = UIImage.FromBundle ("tabIconPoints");
		}
	}
}

