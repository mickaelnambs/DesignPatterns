using DesignPatterns.Bridge.Interface;

namespace DesignPatterns.Bridge.Implementation
{
    public class SMSSenderBridge : INotificationSenderBridge
    {
        public void Send(string recipient, string message)
        {
            Console.WriteLine($"Sending SMS to {recipient}: {message}");
        }
    }
}
