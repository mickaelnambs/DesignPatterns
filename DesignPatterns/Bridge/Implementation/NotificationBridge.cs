using DesignPatterns.Bridge.Interface;

namespace DesignPatterns.Bridge.Implementation
{
    public abstract class NotificationBridge
    {
        protected INotificationSenderBridge Sender;

        protected NotificationBridge(INotificationSenderBridge sender)
        {
            Sender = sender;
        }

        public abstract void Send();
    }
}
