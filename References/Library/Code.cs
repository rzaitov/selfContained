using System;
using System.Collections.Generic;
using MongoDB.Driver;

namespace Library
{

	public class BugRepository
	{
		readonly IMongoCollection<Bug> collection;

		public BugRepository (IMongoDatabase db)
		{
			collection = db.GetCollection<Bug> ("bugs");
		}

		public Bug Find (int id)
		{
			return collection.Find (Builders<Bug>.Filter.Eq (b => b.Id, id)).FirstOrDefault ();
		}
	}

	public class RepositoryFactory
	{
		readonly string connectionString;

		public RepositoryFactory (string connectionString)
		{
			this.connectionString = connectionString;
		}

		public BugRepository CreateBugRepository ()
		{
			var dbFactory = new DatabaseFactory (connectionString);
			var db = dbFactory.Create ();

			return new BugRepository (db);
		}
	}

	public class DatabaseFactory
	{
		readonly string connectionString;

		public DatabaseFactory (string connectionString)
		{
			this.connectionString = connectionString;
		}

		public IMongoDatabase Create ()
		{
			var mongoUrl = new MongoUrl (connectionString);
			var client = new MongoClient (mongoUrl);
			return client.GetDatabase (mongoUrl.DatabaseName);
		}
	}

	public class Bug
	{
		public int Id { get; set; }
		public DateTime creation_time { get; set; }
		public string status { get; set; }
		public string summary { get; set; }
		public string target_milestone { get; set; }
		public string product { get; set; }
		public string priority { get; set; }
		public string severity { get; set; }
		public string component { get; set; }
		public string resolution { get; set; }
		public string assigned_to { get; set; }
		public DateTime last_change_time { get; set; }
		public History history { get; set; }
	}

	public class History
	{
		public int Id { get; set; }
		public List<object> Entries { get; set; }
	}

	public class HistoryItem
	{
		public DateTime when { get; set; }
		public string who { get; set; }
		public List<Change> changes { get; set; }
	}

	public class Change
	{
		public string field_name { get; set; }
		public string removed { get; set; }
		public string added { get; set; }
	}
}
