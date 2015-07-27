using System;

using UIKit;
using System.Collections.Generic;

namespace CustomCellXI
{
	public partial class ViewController : UIViewController, IUITableViewDataSource
	{
		List<string> items;

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			items = new List<string> ();
			for (int i = 0; i < 20; i++) {
				items.Add (string.Format ("item {0}", i));
			}

			Table.DataSource = this;
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public nint RowsInSection (UITableView tableView, nint section)
		{
			return items.Count;
		}
		public UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			var cell = (CustomCell)tableView.DequeueReusableCell ("myCell");
			if (cell == null) {
				tableView.RegisterNibForCellReuse (UINib.FromName("CustomCell", null), "myCell");
				cell = (CustomCell)tableView.DequeueReusableCell ("myCell");
			}

			return cell;
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

