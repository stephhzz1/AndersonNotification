using ExternalAccountWebAuthentication.ApiController;
using ExternalAccountWebAuthentication.Authentication;

namespace AndersonNotificationWeb.ApiControllers
{
    [ApiAuthorizationFilter(false, new string[0])]
    public class BaseApiController : ExternalAccountBaseApiController
    {
    }
}