using System;
using MongoDB.Driver;

namespace DebuggerIssue
{
	class MainClass
	{
		public static void Main (string [] args)
		{
			var fb = Builders<Person>.Filter;
			var ub = Builders<Person>.Update;

			var filter = fb.Eq (p => p.Name, "rustam");

			Console.WriteLine (filter);

			string tmp = "name";
			Console.WriteLine (tmp);

		}
	}

	public class Person
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
	}
}
