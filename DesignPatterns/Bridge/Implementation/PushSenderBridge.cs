using DesignPatterns.Bridge.Interface;

namespace DesignPatterns.Bridge.Implementation
{
    public class PushSenderBridge : INotificationSenderBridge
    {
        public void Send(string recipient, string message)
        {
            Console.WriteLine($"Sending Push Notification to {recipient}: {message}");
        }
    }
}
