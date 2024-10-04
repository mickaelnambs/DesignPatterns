namespace DesignPatterns.Prototype
{
    public class PushNotificationPrototype : NotificationPrototype
    {
        public string DeviceToken { get; set; } = string.Empty;

        public override void Send()
        {
            Console.WriteLine($"Sending Push Notification to {Recipient} with device: {DeviceToken} and message: {Message}");
        }

        public override NotificationPrototype Clone()
        {
            return new PushNotificationPrototype
            {
                Recipient = this.Recipient,
                Message = this.Message,
                DeviceToken = this.DeviceToken
            };
        }
    }
}
