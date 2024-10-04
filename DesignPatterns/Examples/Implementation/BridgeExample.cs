using DesignPatterns.Bridge.Implementation;
using DesignPatterns.Examples.Interface;

namespace DesignPatterns.Examples.Implementation
{
    public class BridgeExample : IPatternExample
    {
        public void Demonstrate()
        {
            Console.WriteLine("Bridge Pattern Demonstration");

            var pushSender = new PushSenderBridge();
            var smsSender = new SMSSenderBridge();
            var emailSender = new EmailSenderBridge();

            var pushNotification = new SimpleNotificationBridge(pushSender, "User1", "Hello via Push");
            pushNotification.Send();

            var smsNotification = new SimpleNotificationBridge(smsSender, "User2", "Hello via SMS");
            smsNotification.Send();

            var emailNotification = new SimpleNotificationBridge(emailSender, "user3@example.com", "Hello via Email");
            emailNotification.Send();

            var priorityPushNotification = new PriorityNotificationBridge(pushSender, "User4", "Urgent message via Push", 3);
            priorityPushNotification.Send();

            var priorityEmailNotification = new PriorityNotificationBridge(emailSender, "user5@example.com", "Urgent message via Email", 2);
            priorityEmailNotification.Send();
        }
    }
}
