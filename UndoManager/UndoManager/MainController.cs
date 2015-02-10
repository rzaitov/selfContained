using System;
using UIKit;
using Foundation;

namespace UndoManager
{
	public class MainController : UIViewController
	{
		NSUndoManager undoManager;

		public MainController ()
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			View.BackgroundColor = UIColor.Cyan;

			undoManager = new NSUndoManager ();

			NSObject target = undoManager.PrepareWithInvocationTarget (this);
			Console.WriteLine (target);
		}
	}
}

