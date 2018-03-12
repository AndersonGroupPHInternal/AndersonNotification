using AndersonNotificationModel;
using ExternalAccountWebAuthentication.Authentication;
using System.Web.Http;

namespace AndersonNotificationWeb.ApiControllers
{
    public class TestApiController : BaseApiController
    {   
        public TestApiController()
        {
        }

        [ApiAuthorizationFilter(true)]
        [HttpPost]
        public IHttpActionResult LoggedOut(EmailNotification emailNotification)
        {
            return Ok(emailNotification);
        }

        [ApiAuthorizationFilter(false)]
        [HttpPost]
        public IHttpActionResult LoggedIn(EmailNotification emailNotification)
        {
            return Ok(emailNotification);
        }

        [ApiAuthorizationFilter(false, new string[] { "AndersonNotificationAdministrator" })]
        [HttpPost]
        public IHttpActionResult LoggedInWithRole(EmailNotification emailNotification)
        {
            return Ok(emailNotification);
        }
    }
}