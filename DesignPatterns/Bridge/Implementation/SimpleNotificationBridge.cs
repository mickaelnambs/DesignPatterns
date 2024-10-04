using DesignPatterns.Bridge.Interface;

namespace DesignPatterns.Bridge.Implementation
{
    public class SimpleNotificationBridge : NotificationBridge
    {
        private readonly string _recipient;
        private readonly string _message;

        public SimpleNotificationBridge(INotificationSenderBridge sender, string recipient, string message)
            : base(sender)
        {
            _recipient = recipient;
            _message = message;
        }

        public override void Send()
        {
            Sender.Send(_recipient, _message);
        }
    }
}
