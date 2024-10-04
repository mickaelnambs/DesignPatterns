namespace DesignPatterns.Prototype
{
    public abstract class NotificationPrototype
    {
        protected string Recipient {  get; set; } = string.Empty;
        protected string Message { get; set; } = string.Empty;

        public void SetRecipient(string recipient)
        {
            Recipient = recipient;
        }

        public void SetMessage(string message)
        {
            Message = message;
        }

        public abstract void Send();
        public abstract NotificationPrototype Clone();
    }
}
