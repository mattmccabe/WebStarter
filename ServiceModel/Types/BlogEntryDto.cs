using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace ServiceModel
{
	public class BlogEntryDto
	{
		public BlogEntryDto ()
		{
		}

		[BsonId(IdGenerator=typeof(MongoDB.Bson.Serialization.IdGenerators.GuidGenerator))]
		public Guid Id { get ; set ; }
		public string PrimaryImageUrl { get; set; }
		public bool Published { get ; set; }
		public string Title { get; set; }
		public string Summary { get; set; }
		public string Markdown { get; set; }
		public List<String> Tags { get; set; }

	}
}

