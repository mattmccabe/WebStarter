using System;
using ServiceStack.ServiceHost;

namespace ServiceModel
{
	[Route("/blogs", "GET")]
	public class GetBlogPosts
	{
	
	}

	[Route("/blogs/{Id}", "GET")]
	public class GetBlogEntry:BlogEntryDto
	{

	}

	[Route("/blogs", "POST")]
	public class AddBlogEntry:BlogEntryDto
	{

	}

	[Route("/blogs/{Id}", "PUT")]
	public class UpdateBlogEntry:BlogEntryDto
	{

	}

}

