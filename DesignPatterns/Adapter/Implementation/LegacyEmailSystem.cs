using DesignPatterns.Adapter.Interface;

namespace DesignPatterns.Adapter.Implementation
{
    public class LegacyEmailSystem : ILegacyNotificationSystem
    {
        public void SendNotification(Dictionary<string, string> data)
        {
            Console.WriteLine($"Legacy Email System: Sending email to {data["to"]} with message: {data["body"]}");
        }
    }
}
