using System;
using ServiceStack.ServiceHost;
using Api;
using ServiceModel;
using System.Collections.Generic;

namespace ServiceInterface
{
	public class FaqService:IService
	{
		private FaqApi _api;

		public FaqService ()
		{
			_api = new FaqApi ();
		}

		public List<FaqDto> Get(GetFaqs request)
		{
			return _api.GetFaqs ();
		}

		public void Post(AddFaq request)
		{
			_api.Save (request);
		}

		public void Put(UpdateFaq request)
		{
			_api.Save (request);
		}
	}
}

