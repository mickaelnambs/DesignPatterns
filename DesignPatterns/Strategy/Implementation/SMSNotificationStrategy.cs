using DesignPatterns.Strategy.Interface;

namespace DesignPatterns.Strategy.Implementation
{
    public class SMSNotificationStrategy : INotificationStrategy
    {
        public void Send()
        {
            Console.WriteLine("Sending a SMS notification\n");
        }
    }
}
