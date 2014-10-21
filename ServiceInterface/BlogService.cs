using System;
using ServiceStack.ServiceHost;
using Api;
using ServiceModel;
using System.Collections.Generic;

namespace ServiceInterface
{
	public class BlogService:IService
	{
		private BlogApi _api;

		public BlogService ()
		{
			_api = new BlogApi ();
		}

		public List<BlogEntryDto> Get(GetBlogPosts request)
		{
			return _api.GetBlogEntries ();
		}

		public void Post(AddBlogEntry request)
		{
			_api.Save (request);
		}

		public void Put(UpdateBlogEntry request)
		{
			_api.Save (request);
		}

		public BlogEntryDto Get(GetBlogEntry request)
		{
			return _api.GetBlogEntry (request.Id);
		}

	}
}

