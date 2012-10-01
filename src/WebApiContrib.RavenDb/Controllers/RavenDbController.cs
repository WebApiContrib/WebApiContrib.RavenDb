using System.Web.Http;
using Raven.Client;

namespace WebApiContrib.RavenDb.Controllers {
	/// <summary>
	/// This class contains a ASP.NET Web API base controller for use with RavenDb
	/// </summary>
	public abstract class RavenDbController : ApiController {
		public IDocumentSession Session { get; set; }
	}
}