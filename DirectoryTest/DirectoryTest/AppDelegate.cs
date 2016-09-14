using System;
using System.IO;
using System.Runtime.InteropServices;

using UIKit;
using Foundation;
using ObjCRuntime;

namespace DirectoryTest
{
	[Register ("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		public override UIWindow Window { get; set; }

		[DllImport (Constants.FoundationLibrary)]
		public static extern IntPtr NSHomeDirectory ();

		public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{
			// https://developer.xamarin.com/guides/ios/application_fundamentals/working_with_the_file_system/

			Console.WriteLine ("Native home directory:");
			Console.WriteLine (GetHomeDirectoryNative());
			Console.WriteLine ("---");

			Console.WriteLine ("Native home managed:");
			Console.WriteLine (GetHomeDirectoryManaged ());
			Console.WriteLine ("---");

			var bundle = Path.GetFullPath (".");
			Console.WriteLine ("bundle path:");
			Console.WriteLine (bundle);
			Console.WriteLine ("---");


			Console.WriteLine ("List Environment.SpecialFolder");
			//var values = Enum.GetValues (typeof (Environment.SpecialFolder));
			//foreach (Environment.SpecialFolder item in values) {
			//	Console.WriteLine (item);
			//	Console.WriteLine (Environment.GetFolderPath (item));
			//	Console.WriteLine ("---");
			//}

			return true;
		}

		string GetHomeDirectoryNative ()
		{
			return (NSString)Runtime.GetNSObject (NSHomeDirectory ());
		}

		string GetHomeDirectoryManaged ()
		{
			return Path.Combine (Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments), "..");
			//return Path.GetFullPath (Path.Combine (Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments), ".."));
		}
	}
}

