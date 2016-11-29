using System;

using Library;

namespace Client
{
	class MainClass
	{
		const string connectionStr = "mongodb://xqa_staging_readwrite:y0Dawg8j3@xqa-mongodb.cloudapp.net:27017/xqa_staging";

		public static void Main (string [] args)
		{
			var repo = new RepositoryFactory (connectionStr).CreateBugRepository ();
			var bug = repo.Find (1);
			Console.WriteLine (bug);
		}
	}
}
