using System;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace ServiceModel
{
	public class FaqDto
	{
		public FaqDto ()
		{

		}
			
		[BsonId(IdGenerator=typeof(MongoDB.Bson.Serialization.IdGenerators.GuidGenerator))]
		public Guid Id { get ; set ; }
		public string Question { get; set; }
		public string Answer { get; set; }
		public string Category { get; set; }

	}
}

