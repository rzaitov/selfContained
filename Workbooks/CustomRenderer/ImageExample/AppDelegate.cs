﻿using System;
using System.IO;

using AppKit;
using Foundation;

using CoreGraphics;
using ImageIO;
using MobileCoreServices;

namespace ImageExample
{
	[Register ("AppDelegate")]
	public class AppDelegate : NSApplicationDelegate
	{
		public AppDelegate ()
		{
		}

		public override void DidFinishLaunching (NSNotification notification)
		{
		}

		public override void WillTerminate (NSNotification notification)
		{
			// Insert code here to tear down your application
		}
	}
}
