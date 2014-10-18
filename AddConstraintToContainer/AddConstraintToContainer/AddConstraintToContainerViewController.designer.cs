// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using Foundation;
using UIKit;
using System.CodeDom.Compiler;

namespace AddConstraintToContainer
{
	[Register ("AddConstraintToContainerViewController")]
	partial class AddConstraintToContainerViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView MyCoolContainer { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (MyCoolContainer != null) {
				MyCoolContainer.Dispose ();
				MyCoolContainer = null;
			}
		}
	}
}
