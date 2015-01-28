using System;
using System.IO;

using NUnit.Framework;

using Xamarin.UITest;
using Xamarin.UITest.iOS;


namespace MetalTexture.XUI
{
	[TestFixture ()]
	public class Test
	{
		const string API_KEY = "paste your key here";
		const string DEVICE_WIFI_IP = "put your device ip here";
		const string BUNDLE_IDENTIFIER = "com.your-company.MetalTexturedQuad";

		iOSApp app;

		[SetUp ()]
		public void SetUp ()
		{
			app = ConfigureApp.Debug ().iOS.InstalledApp (BUNDLE_IDENTIFIER).DeviceIp (DEVICE_WIFI_IP).ApiKey (API_KEY).StartApp ();
		}

		[Test]
		public void Test1()
		{
			Assert.True (true);
		}

		[Test]
		public void Test2()
		{
			Assert.True (true);
		}

		[TestFixtureTearDown]
		public void TestFixtureTearDown ()
		{
			app = null;
		}
	}
}