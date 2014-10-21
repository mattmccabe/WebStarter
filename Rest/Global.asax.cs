using ServiceStack;
using ServiceStack.WebHost.Endpoints;
using ServiceStack.Api.Swagger;
using ServiceStack.Text;
using System.Configuration;
using ServiceInterface;


namespace Rest
{
	using System;
	using System.Collections;
	using System.ComponentModel;
	using System.Web;
	using System.Web.SessionState;



	public class Global : System.Web.HttpApplication
	{
		public class AppHost : AppHostBase
		{
			//Tell Service Stack the name of your application and where to find your web services
			public AppHost() : base("WebStarter Rest Api", typeof(FaqService).Assembly) { }

			public override void Configure(Funq.Container container)
			{
				//register any dependencies your services use, e.g:
				//container.Register<ICacheClient>(new MemoryCacheClient());
				Plugins.Add (new SwaggerFeature());
			}
		}

		//Initialize your application singleton
		protected void Application_Start(object sender, EventArgs e)
		{
			//Register custom serialization example
			ServiceStack.Text.JsConfig.DateHandler = ServiceStack.Text.JsonDateHandler.ISO8601;

			JsConfig<ServiceStack.Api.Swagger.ResourceResponse>.OnSerializingFn = rr => {
				rr.BasePath = ConfigurationManager.AppSettings ["swaggerBasePath"];
				return rr;
			};
			JsConfig<ServiceStack.Api.Swagger.ResourcesResponse>.OnSerializingFn = rr => {
				rr.BasePath = ConfigurationManager.AppSettings ["swaggerBasePath"];
				return rr;
			};

			new AppHost().Init();
		}

		protected void Session_Start (Object sender, EventArgs e)
		{
		}

		protected void Application_BeginRequest (Object sender, EventArgs e)
		{
		}

		protected void Application_EndRequest (Object sender, EventArgs e)
		{
		}

		protected void Application_AuthenticateRequest (Object sender, EventArgs e)
		{
		}

		protected void Application_Error (Object sender, EventArgs e)
		{
		}

		protected void Session_End (Object sender, EventArgs e)
		{
		}

		protected void Application_End (Object sender, EventArgs e)
		{
		}
	}
}

