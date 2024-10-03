using DesignPatterns.Strategy.Interface;

namespace DesignPatterns.Decorator
{
    public class AlertNotificationDecorator : NotificationDecorator
    {
        public AlertNotificationDecorator(INotificationStrategy notification) : base(notification) { }

        public override void Send()
        {
            _notification.Send();
            Console.WriteLine("Sending an alert for the notification.");
        }
    }
}
