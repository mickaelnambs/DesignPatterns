using DesignPatterns.Adapter.Interface;

namespace DesignPatterns.Adapter.Implementation
{
    public class ModernSMSSystem : IModernNotificationSystem
    {
        public void Send(string recipient, string message)
        {
            Console.WriteLine($"Modern SMS System: Sending SMS to {recipient} with message: {message}");
        }
    }
}
