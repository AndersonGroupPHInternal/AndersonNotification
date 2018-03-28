using System.Threading.Tasks;
using AndersonNotificationModel;

namespace AndersonNotificationConsumer
{
    public class EmailNotificationApi : AndersonNotificationConsumerBase, IEmailNotificationApi
    {
        public EmailNotificationApi()
        {
        }

        public async Task<EmailNotification> Create(EmailNotification emailNotification)
        {
            DestinationUrl = "/api/EmailNotificationApi/Create";
            return await PostWithAuthentication(emailNotification);
        }
    }
}
