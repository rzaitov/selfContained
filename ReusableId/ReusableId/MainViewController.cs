using System;
using UIKit;

namespace ReusableId
{
	public class MainViewController : UIViewController
	{
		UITableView table;
		DataSource source;

		public MainViewController ()
		{
		}

		public override void LoadView ()
		{
			base.LoadView ();
			table = new UITableView ();
			View = table;
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			source = new DataSource ();
			table.DataSource = source;
		}
	}
}

