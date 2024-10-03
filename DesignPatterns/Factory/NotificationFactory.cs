using DesignPatterns.Strategy.Implementation;
using DesignPatterns.Strategy.Interface;

namespace DesignPatterns.Factory
{
    public static class NotificationFactory
    {
        public static INotificationStrategy CreateStrategy(string type)
        {
            return type.ToLower() switch
            {
                "email" => new EmailNotificationStrategy(),
                "sms" => new SMSNotificationStrategy(),
                "push" => new PushNotificationStrategy(),
                _ => null
            };
        }
    }
}
