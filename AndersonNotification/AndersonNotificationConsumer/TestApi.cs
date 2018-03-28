using System.Threading.Tasks;
using AndersonNotificationModel;

namespace AndersonNotificationConsumer
{
    public class TestApi : AndersonNotificationConsumerBase, ITestApi
    {
        public async Task<EmailNotification> LoggedOut(EmailNotification emailNotification)
        {
            DestinationUrl = "/api/TestApi/LoggedOut";
            return await Post(emailNotification);
        }


        public async Task<EmailNotification> LoggedIn(EmailNotification emailNotification)
        {
            DestinationUrl = "/api/TestApi/LoggedIn";
            return await PostWithAuthentication(emailNotification);
        }
    }
}
