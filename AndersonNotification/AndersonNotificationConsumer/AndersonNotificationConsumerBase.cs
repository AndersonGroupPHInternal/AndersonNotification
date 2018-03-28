using System.Configuration;
using BaseConsumer;

namespace AndersonNotificationConsumer
{
    public abstract class AndersonNotificationConsumerBase : Consumer
    {
        public AndersonNotificationConsumerBase()
        {
            BaseUrl = ConfigurationManager.AppSettings["AndersonNotificationUrl"];
            Password = ConfigurationManager.AppSettings["AndersonNotificationPassword"];
            Username = ConfigurationManager.AppSettings["AndersonNotificationUsername"];
        }
    }
}
