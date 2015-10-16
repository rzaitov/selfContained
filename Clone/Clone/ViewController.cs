using System;

using UIKit;
using Foundation;
using CoreGraphics;

namespace Clone
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

			var a1 = new UICollectionViewLayoutAttributes () {
				Center = new CGPoint (1, 2)
			};
			var a2 = a1.Copy ();
			Console.WriteLine ("a1 IsEqual a2 = {0}", a2.IsEqual(a1));

			var attr = new MyCollectionViewGridLayoutAttributes {
				BackgroundColor = UIColor.Red
			};

			var cloneArrt = (MyCollectionViewGridLayoutAttributes)attr.Clone ();

			Console.WriteLine ("cloneArrt.Equals(attr) = {0}", cloneArrt.Equals(attr));
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}

	[Register("MyCollectionViewGridLayoutAttributes")]
	public class MyCollectionViewGridLayoutAttributes : UICollectionViewLayoutAttributes
	{
		public UIColor BackgroundColor { get; set; }

		public override int GetHashCode ()
		{
			return GetNativeHash().GetHashCode ();
		}

		public override nuint GetNativeHash ()
		{
			nuint prime = 31;
			nuint result = 1;
			result = prime * result + base.GetNativeHash (); // the same as base.GetNativeHash()
			result = prime * result + BackgroundColor.GetNativeHash ();
			return result;
		}

		public override bool Equals (object obj)
		{
			if(obj.GetType() != typeof(MyCollectionViewGridLayoutAttributes))
				return false;

			return IsEqual ((NSObject)obj);
		}

		public override bool IsEqual (NSObject obj)
		{
			if (obj.GetType () != typeof(MyCollectionViewGridLayoutAttributes))
				return false;

			var other = (MyCollectionViewGridLayoutAttributes)obj;
			if (!base.IsEqual (other))
				return false;

			if (!BackgroundColor.Equals (other.BackgroundColor))
				return false;

			return true;
		}

		public override NSObject Copy (NSZone zone)
		{
			var attributes = (MyCollectionViewGridLayoutAttributes)base.Copy (zone);
			attributes.BackgroundColor = BackgroundColor;
			return attributes;
		}

		public object Clone ()
		{
			return Copy ();
		}
	}
}

