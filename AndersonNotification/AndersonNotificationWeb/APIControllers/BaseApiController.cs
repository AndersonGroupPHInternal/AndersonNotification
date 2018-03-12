using ExternalAccountWebAuthentication.ApiController;
using ExternalAccountWebAuthentication.Authentication;

namespace AndersonNotificationWeb.ApiControllers
{
    [ApiAuthorizationFilter(false, new string[] { "AndersonNotificationAdministrator" })]
    public class BaseApiController : ExternalAccountBaseApiController
    {
    }
}