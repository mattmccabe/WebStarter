using System.Collections.Generic;
using ServiceStack.ServiceInterface.Auth;
using ServiceStack.ServiceInterface;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface.Cors;

namespace ServiceInterface
{
	[Route("/session")]
	public class SessionInfoRequest
	{
	}
		

	public class SessionService:Service,IRequiresRequestContext
	{
		protected AuthUserSession UserSession
		{
			get
			{
				return base.SessionAs<AuthUserSession>();
			}
		}

		public SessionService()
		{
		}


		public AuthUserSession Get(SessionInfoRequest request)
		{
			return UserSession;
		}
			
		public AuthUserSession Options(SessionInfoRequest request)
		{
			return null;
		}
	}
}

