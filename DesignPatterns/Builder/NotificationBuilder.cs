using DesignPatterns.Decorator;
using DesignPatterns.Factory;
using DesignPatterns.Strategy.Interface;

namespace DesignPatterns.Builder
{
    public class NotificationBuilder
    {
        private string? _type;
        private bool _withLogging = false;
        private bool _withAlert = false;

        public NotificationBuilder SetType(string type)
        {
            _type = type;
            return this;
        }

        public NotificationBuilder EnableLogging(bool enable = true)
        {
            _withLogging = enable;
            return this;
        }

        public NotificationBuilder EnableAlert(bool enable = true)
        {
            _withAlert = enable;
            return this;
        }

        public INotificationStrategy? Build()
        {
            var strategy = NotificationFactory.CreateStrategy(_type);
            if (strategy == null)
            {
                return null;
            }

            if (_withLogging)
            {
                strategy = new LoggingNotificationDecorator(strategy);
            }

            if (_withAlert)
            {
                strategy = new AlertNotificationDecorator(strategy);
            }

            return strategy;
        }
    }
}
