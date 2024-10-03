using DesignPatterns.Decorator;
using DesignPatterns.Examples.Interface;

namespace DesignPatterns.Examples.Implementation
{
    public class DecoratorExample : IPatternExample
    {
        public void Demonstrate()
        {
            Console.WriteLine("Decorator Pattern Demonstration");

            Console.Write("Choose notification type (email/sms/push): ");
            string notificationType = Console.ReadLine() ?? "";

            Console.Write("Add logging? (y/n): ");
            bool withLogging = Console.ReadLine()?.ToLower() == "y";

            Console.Write("Add alert? (y/n): ");
            bool withAlert = Console.ReadLine()?.ToLower() == "y";

            var strategy = Notification.CreateStrategy(notificationType, withLogging, withAlert);

            if (strategy != null)
            {
                strategy.Send();
            }
            else
            {
                Console.WriteLine("Invalid notification type.");
            }
        }
    }
}
