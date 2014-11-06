using System;
using UIKit;
using Foundation;

namespace ReusableId
{
	public class DataSource : UITableViewDataSource
	{
		const string cellId = "cellId";

		public DataSource ()
		{
		}

		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell ((NSString)cellId);
			cell = cell ?? new CustomCell (UITableViewCellStyle.Default, (NSString)cellId);

			cell.TextLabel.Text = indexPath.Row.ToString ();
			return cell;
		}

		public override nint RowsInSection (UITableView tableView, nint section)
		{
			return 100;
		}
	}
}

