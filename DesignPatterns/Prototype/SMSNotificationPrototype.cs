namespace DesignPatterns.Prototype
{
    internal class SMSNotificationPrototype : NotificationPrototype
    {
        public string PhoneNumber { get; set; } = string.Empty;

        public override void Send()
        {
            Console.WriteLine($"Sending SMS to {Recipient} with phone number: {PhoneNumber} and message: {Message}");
        }

        public override NotificationPrototype Clone()
        {
            return new SMSNotificationPrototype
            {
                Recipient = this.Recipient,
                Message = this.Message,
                PhoneNumber = this.PhoneNumber
            };
        }
    }
}
