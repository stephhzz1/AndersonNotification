using ExternalAccountWebAuthentication.Authentication;
using ExternalAccountWebAuthentication.Controller;

namespace AndersonNotificationWeb.Controllers
{
    [MvcAuthorizationFilterAttribute(false, "Credential", "Login", new string[] { "AndersonNotification" })]
    public class BaseController : ExternalAccountBaseController
    {
    }
}