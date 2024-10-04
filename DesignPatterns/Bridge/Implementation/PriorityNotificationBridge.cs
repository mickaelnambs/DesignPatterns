using DesignPatterns.Bridge.Interface;

namespace DesignPatterns.Bridge.Implementation
{
    public class PriorityNotificationBridge : NotificationBridge
    {
        private readonly string _recipient;
        private readonly string _message;
        private readonly int _priority;

        public PriorityNotificationBridge(INotificationSenderBridge sender, string recipient, string message, int priority)
            : base(sender)
        {
            _recipient = recipient;
            _message = message;
            _priority = priority;
        }

        public override void Send()
        {
            string priorityPrefix = new string('!', _priority);
            Sender.Send(_recipient, $"{priorityPrefix} {_message}");
        }
    }
}
