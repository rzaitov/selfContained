using System;
using System.Drawing;

using Foundation;
using UIKit;
using System.Runtime.InteropServices;

namespace MarshalStructToPtr
{
	public partial class MarshalStructToPtrViewController : UIViewController
	{
		[StructLayout(LayoutKind.Sequential, Pack=1)]
		struct AVAudioTapProcessorContext
		{
			public bool SupportedTapProcessingFormat;

			public bool IsNonInterleaved;

			public double SampleRate;

//			public double SampleCount;
//
//			public float LeftChannelVolume;
//
//			public float RightChannelVolume;

//			public IntPtr AudioUnit;

//			public IntPtr Self;
		}

		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public MarshalStructToPtrViewController (IntPtr handle) : base (handle)
		{
			Console.WriteLine (Marshal.SizeOf (typeof(AVAudioTapProcessorContext)));
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			AVAudioTapProcessorContext context = new AVAudioTapProcessorContext ();

			int size = Marshal.SizeOf (typeof(AVAudioTapProcessorContext));
			IntPtr handle = Marshal.AllocHGlobal (size);
			Marshal.StructureToPtr<AVAudioTapProcessorContext> (context, handle, false);

			
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion
	}
}

