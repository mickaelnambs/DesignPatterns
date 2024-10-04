using DesignPatterns.Adapter.Implementation;
using DesignPatterns.Adapter.Interface;
using DesignPatterns.Examples.Interface;

namespace DesignPatterns.Examples.Implementation
{
    public class AdapterExample : IPatternExample
    {
        public void Demonstrate()
        {
            Console.WriteLine("Adapter Pattern Demonstration");

            var legacyEmail = new LegacyEmailSystem();

            var legacyAdapter = new LegacyToModernNotificationAdapter(legacyEmail);

            var modernEmail = new ModernEmailSystem();
            var modernSMS = new ModernSMSSystem();

            SendNotification(legacyAdapter, "user1@example.com", "Hello from adapted legacy system");

            SendNotification(modernEmail, "user2@example.com", "Hello from modern email system");
            SendNotification(modernSMS, "+1234567890", "Hello from modern SMS system");
        }

        private static void SendNotification(IModernNotificationSystem notifier, string recipient, string message)
        {
            notifier.Send(recipient, message);
        }
    }
}
