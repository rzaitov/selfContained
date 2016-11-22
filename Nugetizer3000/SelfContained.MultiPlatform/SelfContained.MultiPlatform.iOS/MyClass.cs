using System;

namespace SelfContained.MultiPlatform
{
	public class MyClass
	{
		public string GetString ()
		{
			return "string on iOS" + MySharedClass.GetSharedString ();
		}
	}
}
