using DesignPatterns.Examples.Interface;
using DesignPatterns.Singleton;

namespace DesignPatterns.Examples.Implementation
{
    public class SingletonExample : IPatternExample
    {
        public void Demonstrate()
        {
            Console.WriteLine("Singleton Pattern Demonstration");

            var configInstance = NotificationConfigSingleton.Instance;

            // Display the initial email configuration.
            var emailConfig = configInstance.GetConfig("email");
            Console.WriteLine($"Initial Email Config - Host: {emailConfig["host"]}");

            // Modify the configuration.
            configInstance.SetConfig("email", new Dictionary<string, object>
            {
                ["host"] = "new-smtp.example.com",
                ["port"] = 465,
                ["username"] = "newuser@example.com",
                ["password"] = "newpassword123"
            });

            // Display the updated email configuration.
            var updatedEmailConfig = configInstance.GetConfig("email");
            Console.WriteLine($"Updated Email Config - Host: {updatedEmailConfig["host"]}");

            // Use the notifiers.
            var emailNotifier = new EmailNotifier();
            var smsNotifier = new SMSNotifier();

            emailNotifier.SendEmail("user@example.com", "Hello via Email");
            smsNotifier.SendSMS("+1234567890", "Hello via SMS");

            // Demonstrate that it is still the same instance.
            var anotherConfigInstance = NotificationConfigSingleton.Instance;
            var emailConfigAgain = anotherConfigInstance.GetConfig("email");
            Console.WriteLine($"Email Config from another instance - Host: {emailConfigAgain["host"]}");
        }
    }
}
