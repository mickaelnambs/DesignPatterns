using DesignPatterns.Bridge.Interface;

namespace DesignPatterns.Bridge.Implementation
{
    public class EmailSenderBridge : INotificationSenderBridge
    {
        public void Send(string recipient, string message)
        {
            Console.WriteLine($"Sending Email to {recipient}: {message}");
        }
    }
}
