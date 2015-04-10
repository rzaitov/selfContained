using System;

using Foundation;
using AppKit;

namespace XamComponentStore
{
	public partial class MainWindowController : NSWindowController
	{
		public MainWindowController (IntPtr handle) : base (handle)
		{
		}

		[Export ("initWithCoder:")]
		public MainWindowController (NSCoder coder) : base (coder)
		{
		}

		public MainWindowController () : base ("MainWindow")
		{
		}

		public override void AwakeFromNib ()
		{
			base.AwakeFromNib ();

			WebView.MainFrame.LoadRequest (new NSUrlRequest (NSUrl.FromString ("http://components.xamarin.com/")));
		}

		public new MainWindow Window {
			get { return (MainWindow)base.Window; }
		}
	}
}
