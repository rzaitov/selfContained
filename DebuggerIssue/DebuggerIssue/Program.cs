using System;
using MongoDB.Driver;

namespace DebuggerIssue
{
	class MainClass
	{
		public static void Main (string [] args)
		{
			Console.WriteLine ("Step1. Init");
			var fb = Builders<Person>.Filter;
			var ub = Builders<Person>.Update;

			Console.WriteLine ("Step2. Use expressions");
			var filter = fb.Eq (p => p.Name, "rustam");

			Console.WriteLine ("Step3. print filter to console (avoid unused vars)");
			Console.WriteLine (filter);

			Console.WriteLine ("Step4. some boilerplate");
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
