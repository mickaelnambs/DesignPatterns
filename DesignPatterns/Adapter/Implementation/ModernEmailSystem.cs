using DesignPatterns.Adapter.Interface;

namespace DesignPatterns.Adapter.Implementation
{
    public class ModernEmailSystem : IModernNotificationSystem
    {
        public void Send(string recipient, string message)
        {
            Console.WriteLine($"Modern Email System: Sending email to {recipient} with message: {message}");
        }
    }
}
