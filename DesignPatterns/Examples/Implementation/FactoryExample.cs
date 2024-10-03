using DesignPatterns.Examples.Interface;
using DesignPatterns.Factory;
using DesignPatterns.Strategy.Interface;

namespace DesignPatterns.Examples.Implementation
{
    public class FactoryExample : IPatternExample
    {
        public void Demonstrate()
        {
            Console.WriteLine("Factory Pattern Demonstration");

            Console.WriteLine("Choose notification type (email/sms/push): ");
            string? choice = Console.ReadLine();

            INotificationStrategy? strategy = NotificationFactory.CreateStrategy(choice ?? string.Empty);

            if (strategy != null)
            {
                strategy.Send();
            }
            else
            {
                Console.WriteLine("Invalid notification type");
            }
        }
    }
}
