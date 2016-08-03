using AVFoundation;
using Foundation;
using UIKit;

namespace AVMetadataObjectTypeIssue
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
	[Register ("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations

		public override UIWindow Window {
			get;
			set;
		}

		public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{
			var output = new AVCaptureMetadataOutput (); //AVMetadataObjectType
			output.MetadataObjectTypes = AVMetadataObjectType.Face | AVMetadataObjectType.AztecCode;
			System.Console.WriteLine (output.MetadataObjectTypes);
			return true;
		}
	}
}

