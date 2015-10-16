// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace CustomViewXI
{
	[Register ("CustomViewXI")]
	partial class CustomViewXI
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView LeftView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView RightView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (LeftView != null) {
				LeftView.Dispose ();
				LeftView = null;
			}
			if (RightView != null) {
				RightView.Dispose ();
				RightView = null;
			}
		}
	}
}
