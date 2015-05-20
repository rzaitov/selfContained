using System;

namespace MembersHide
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
		}
	}

	class Base
	{
		public void CoolMethod ()
		{
			
		}

		public void AnotherCoolMethod ()
		{
			
		}
	}

	class Derived : Base
	{
		// Rename me with "Cmd + R"
		public void CoolMethod ()
		{
			
		}

		// Rename me with "Cmd + R"
		public new void AnotherCoolMethod ()
		{

		}
	}
}
