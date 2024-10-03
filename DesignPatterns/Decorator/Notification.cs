using DesignPatterns.Strategy.Implementation;
using DesignPatterns.Strategy.Interface;

namespace DesignPatterns.Decorator
{
    public static class Notification
    {
        public static INotificationStrategy? CreateStrategy(string type, bool withLogging = false, bool withAlert = false)
        {
            INotificationStrategy strategy = type.ToLower() switch
            {
                "email" => new EmailNotificationStrategy(),
                "sms" => new SMSNotificationStrategy(),
                "push" => new PushNotificationStrategy(),
                _ => null
            };

            if (strategy == null )
            {
                return null;
            }

            if (withLogging)
            {
                strategy = new LoggingNotificationDecorator(strategy);
            }

            if (withAlert)
            {
                strategy = new AlertNotificationDecorator(strategy);
            }

            return strategy;
        }
    }
}
