using DesignPatterns.Strategy.Interface;

namespace DesignPatterns.Decorator
{
    internal class LoggingNotificationDecorator : NotificationDecorator
    {
        public LoggingNotificationDecorator(INotificationStrategy notification) : base(notification) { }

        public override void Send()
        {
            _notification.Send();
            Console.WriteLine("Logging notification details.");
        }
    }
}
