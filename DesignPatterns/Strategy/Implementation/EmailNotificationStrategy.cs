using DesignPatterns.Strategy.Interface;

namespace DesignPatterns.Strategy.Implementation
{
    public class EmailNotificationStrategy : INotificationStrategy
    {
        public void Send()
        {
            Console.WriteLine("Sending an email notification\n");
        }
    }
}
