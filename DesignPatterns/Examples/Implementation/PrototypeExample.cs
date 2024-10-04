using DesignPatterns.Examples.Interface;
using DesignPatterns.Prototype;

namespace DesignPatterns.Examples.Implementation
{
    public class PrototypeExample : IPatternExample
    {
        public void Demonstrate()
        {
            Console.WriteLine("Prototype Pattern Demonstration");

            var pushPrototype = new PushNotificationPrototype();
            var smsPrototype = new SMSNotificationPrototype();
            var emailPrototype = new EmailNotificationPrototype();

            var push1 = (PushNotificationPrototype)pushPrototype.Clone();
            push1.SetRecipient("User1");
            push1.SetMessage("Hello User1");
            push1.DeviceToken = "user1_device_token";
            push1.Send();

            var sms1 = (SMSNotificationPrototype)smsPrototype.Clone();
            sms1.SetRecipient("User2");
            sms1.SetMessage("Hello User2");
            sms1.PhoneNumber = "1234567890";
            sms1.Send();

            var email1 = (EmailNotificationPrototype)emailPrototype.Clone();
            email1.SetRecipient("user3@example.com");
            email1.Subject = "Welcome";
            email1.SetMessage("Hello User3");
            email1.Send();
        }
    }
}
