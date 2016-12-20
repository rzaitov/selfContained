using System;
using System.Configuration;
using NUnit.Framework;

namespace LibTests
{
	[TestFixture]
	public class MyClass
	{
		[Test]
		public void SimpleTest ()
		{
			ConnectionStringSettings conStr = ConfigurationManager.ConnectionStrings ["TestDatabase_ConnecionString"];
			Assert.AreEqual ("this is test db connection string", conStr.ConnectionString);
		}
	}
}
