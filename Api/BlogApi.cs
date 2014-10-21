using System;
using System.Linq;
using MongoDB.Driver.Linq;
using ServiceModel;
using System.Collections.Generic;

namespace Api
{
	public class BlogApi:MongoBackedApi
	{
		public BlogApi ()
		{

		}

		override protected string CollectionName { get { return "blogs"; } }


		public List<BlogEntryDto> GetBlogEntries()
		{
			return GetCollection<BlogEntryDto> ().FindAll ().ToList();
		}

		public BlogEntryDto GetBlogEntry(Guid id)
		{
			return GetCollection<BlogEntryDto> ().FindOneById (id);
		}

		public void Save(BlogEntryDto blogEntry)
		{
			var c = GetCollection<BlogEntryDto> ();

			c.Save (blogEntry);
		}
	}
}

