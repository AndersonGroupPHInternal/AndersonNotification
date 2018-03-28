using AndersonNotificationFunction;
using AndersonNotificationModel;
using System.Web.Http;

namespace AndersonNotificationWeb.ApiControllers
{
    public class EmailNotificationApiController : BaseApiController
    {
        private IFEmailNotification _iFEmailNotification;        
        public EmailNotificationApiController(IFEmailNotification iFEmailNotification)
        {
            _iFEmailNotification = iFEmailNotification;
        }

        [HttpPost]
        public IHttpActionResult Create(EmailNotification emailNotification)
        {
            emailNotification = _iFEmailNotification.Send(CredentialId, emailNotification);
            return Ok(emailNotification);
        }

    }
}