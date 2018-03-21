using ExternalAccountWebAuthentication.Authentication;
using ExternalAccountWebAuthentication.Controller;

namespace AndersonNotificationWeb.Controllers
{
    [MvcAuthorizationFilter(false, "Credential", "Login", new string[] { "AndersonNotificationAdministrator" })]
    public class BaseController : ExternalAccountBaseController
    {
    }
}