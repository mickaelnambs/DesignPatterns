using DesignPatterns.Builder;
using DesignPatterns.Examples.Interface;

namespace DesignPatterns.Examples.Implementation
{
    public class BuilderExample : IPatternExample
    {
        public void Demonstrate()
        {
            Console.WriteLine("Builder Pattern Demonstration");

            Console.Write("Choose notification type (email/sms/push): ");
            string notificationType = Console.ReadLine() ?? "";

            Console.Write("Add logging? (y/n): ");
            bool withLogging = Console.ReadLine()?.ToLower() == "y";

            Console.Write("Add alert? (y/n): ");
            bool withAlert = Console.ReadLine()?.ToLower() == "y";

            var notificationBuilder = new NotificationBuilder()
                .SetType(notificationType)
                .EnableLogging(withLogging)
                .EnableAlert(withAlert);

            var notification = notificationBuilder.Build();

            if (notification != null)
            {
                notification.Send();
            }
            else
            {
                Console.WriteLine("Invalid notification type.");
            }
        }
    }
}
