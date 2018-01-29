using ExternalAccountWebAuthentication.Authentication;
using System;
using System.Web.Http;

namespace AndersonNotificationWeb.ApiControllers
{
    [RoutePrefix("TestApi")]
    public class TestApiController : BaseApiController
    {
        [Route("Get")]
        public IHttpActionResult Get()
        {
            return Ok(new string[] { "value1", "value2" });
        }
    }
}