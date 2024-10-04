namespace DesignPatterns.Adapter.Interface
{
    public interface ILegacyNotificationSystem
    {
        void SendNotification(Dictionary<string, string> data);
    }
}
