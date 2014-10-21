using System;
using System.Linq;
using MongoDB.Driver.Linq;
using ServiceModel;
using System.Collections.Generic;

namespace Api
{
	public class FaqApi:MongoBackedApi
	{
		public FaqApi ()
		{

		}

		override protected string CollectionName { get { return "faq"; } }


		public List<FaqDto> GetFaqs()
		{
			return GetCollection<FaqDto> ().FindAll ().ToList();
		}

		public void Save(FaqDto faq)
		{
			var c = GetCollection<FaqDto> ();

			c.Save (faq);
		}
	}
}

