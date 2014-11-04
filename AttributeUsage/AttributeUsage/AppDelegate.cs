using System;

using Foundation;
using AppKit;

namespace AttributeUsage
{
	public partial class AppDelegate : NSApplicationDelegate
	{
		MainWindowController mainWindowController;

		public AppDelegate ()
		{
		}

		public override void FinishedLaunching (NSObject notification)
		{
			mainWindowController = new MainWindowController ();
			mainWindowController.Window.MakeKeyAndOrderFront (this);
		}

		[Register("someSelector")]
		void MyTestMethod(NSObject obj1, object obj2)
		{

		}

		[Export("someSelector2")]
		void MyTestMethod2(NSObject obj1, object obj2)
		{

		}

		[Export("someSelector:")]
		void MyTestMethod3(NSObject obj1, object obj2)
		{

		}
	}
}
