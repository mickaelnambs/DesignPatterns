namespace DesignPatterns.Prototype
{
    public class EmailNotificationPrototype : NotificationPrototype
    {
        public string Subject { get; set; } = string.Empty;

        public override void Send()
        {
            Console.WriteLine($"Sending Email to {Recipient} with subject: {Subject} and message: {Message}");
        }

        public override NotificationPrototype Clone()
        {
            return new EmailNotificationPrototype
            {
                Recipient = this.Recipient,
                Message = this.Message,
                Subject = this.Subject,
            };
        }
    }
}
