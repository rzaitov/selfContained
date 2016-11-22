using System;
using JustSingleLibrary;

namespace Client
{
	class MainClass
	{
		public static void Main (string [] args)
		{
			var mc = new MyClass ();
			Console.WriteLine (mc.GetString());
		}
	}
}
