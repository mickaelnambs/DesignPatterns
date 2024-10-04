using DesignPatterns.Adapter.Interface;

namespace DesignPatterns.Adapter.Implementation
{
    public class LegacyToModernNotificationAdapter : IModernNotificationSystem
    {
        private readonly ILegacyNotificationSystem _legacySystem;

        public LegacyToModernNotificationAdapter(ILegacyNotificationSystem legacySystem)
        {
            _legacySystem = legacySystem;
        }

        public void Send(string recipient, string message)
        {
            var data = new Dictionary<string, string>
            {
                {"to", recipient},
                {"body", message},
            };
            _legacySystem.SendNotification(data);
        }   
    }
}
