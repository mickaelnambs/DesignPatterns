using DesignPatterns.Strategy.Interface;

namespace DesignPatterns.Strategy.Implementation
{
    public class PushNotificationStrategy : INotificationStrategy
    {
        public void Send()
        {
            Console.WriteLine("Sending a push notification\n");
        }
    }
}
