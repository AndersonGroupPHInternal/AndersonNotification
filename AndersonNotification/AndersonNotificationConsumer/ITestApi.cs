using System.Threading.Tasks;
using AndersonNotificationModel;

namespace AndersonNotificationConsumer
{
    public interface ITestApi
    {
        Task<EmailNotification> LoggedIn(EmailNotification emailNotification);
        Task<EmailNotification> LoggedOut(EmailNotification emailNotification);
    }
}
