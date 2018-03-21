using ExternalAccountWebAuthentication.ApiController;
using ExternalAccountWebAuthentication.Authentication;

namespace AndersonNotificationWeb.ApiControllers
{
    [ApiAuthorizationFilter(false, new string[] { "AndersonNotificationAdministrator", "AndersonNotificationEmailNotification" })]
    public class BaseApiController : ExternalAccountBaseApiController
    {
    }
}