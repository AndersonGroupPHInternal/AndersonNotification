using System.Threading.Tasks;
using AndersonNotificationModel;

namespace AndersonNotificationConsumer
{
    public interface IEmailNotificationApi
    {
        Task<EmailNotification> Create(EmailNotification emailNotification);
    }
}
