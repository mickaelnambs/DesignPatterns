using DesignPatterns.Strategy.Interface;

namespace DesignPatterns.Decorator
{
    public abstract class NotificationDecorator : INotificationStrategy
    {
        protected INotificationStrategy _notification;

        protected NotificationDecorator(INotificationStrategy notification)
        {
            _notification = notification;
        }

        public abstract void Send();
    }
}
