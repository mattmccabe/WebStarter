using System;
using ServiceStack.ServiceHost;

namespace ServiceModel
{
	[Route("/faqs", "GET")]
	public class GetFaqs
	{
	
	}

	[Route("/faqs", "POST")]
	public class AddFaq:FaqDto
	{

	}

	[Route("/faqs/{Id}", "PUT")]
	public class UpdateFaq:FaqDto
	{

	}

}

