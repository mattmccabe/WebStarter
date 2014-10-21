using System;
using System.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Api
{
	public abstract class MongoBackedApi
	{
		public MongoBackedApi ()
		{

		}

		protected MongoServer GetMongoServer(){

			var client = new MongoClient (ConfigurationManager.AppSettings ["mongoConnect"]);
			return client.GetServer ();
		}

		protected MongoDatabase GetDatabase() {
			var server = GetMongoServer ();
			return server.GetDatabase ("webstarter");
		}

		public MongoCollection<T> GetCollection<T>()
		{
			return GetDatabase ().GetCollection<T>(CollectionName);
		}

		protected abstract string CollectionName { get; }
			
	}
}

