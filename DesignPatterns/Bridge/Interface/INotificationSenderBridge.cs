namespace DesignPatterns.Bridge.Interface
{
    public interface INotificationSenderBridge
    {
        void Send(string recipient, string message);
    }
}
