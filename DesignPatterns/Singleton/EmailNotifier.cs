namespace DesignPatterns.Singleton
{
    public class EmailNotifier
    {
        public void SendEmail(string to, string message)
        {
            var config = NotificationConfigSingleton.Instance.GetConfig("email");
            Console.WriteLine($"Sending email to {to} using SMTP host: {config["host"]}");
            Console.WriteLine($"Message: {message}");
        }
    }
}
