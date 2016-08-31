using System;

using UIKit;

namespace InfiniteRecursion
{
	public partial class ViewController : UIViewController
	{
		protected ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			MethodWithInfiniteRecursion ();
		}

		void MethodWithInfiniteRecursion ()
		{
			var trueCondition = "123".Length == 3;
			if (trueCondition)
				MethodWithInfiniteRecursion ();
		}
	}
}
