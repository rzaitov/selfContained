using System;
using UIKit;
using Foundation;

namespace ReusableId
{
	public class CustomCell : UITableViewCell
	{
		static int i;

		public CustomCell (UITableViewCellStyle style, string reuseId)
			: base(style, reuseId)
		{
			Console.WriteLine (i++);
		}

		public CustomCell (UITableViewCellStyle style, NSString reuseId)
			: base(style, reuseId)
		{
			Console.WriteLine (i++);
		}

	}
}

