namespace DesignPatterns.Singleton
{
    public class SMSNotifier
    {
        public void SendSMS(string to, string message)
        {
            var config = NotificationConfigSingleton.Instance.GetConfig("sms");
            Console.WriteLine($"Sending SMS to {to} using API key: {config["api_key"]}");
            Console.WriteLine($"Message: {message}");
        }
    }
}
