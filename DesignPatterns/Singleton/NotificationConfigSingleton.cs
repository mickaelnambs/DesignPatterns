namespace DesignPatterns.Singleton
{
    public sealed class NotificationConfigSingleton
    {
        private static NotificationConfigSingleton _instance = null;
        private static readonly object _padlock = new object();
        private Dictionary<string, Dictionary<string, object>> _config;

        private NotificationConfigSingleton()
        {
            _config = new Dictionary<string, Dictionary<string, object>>
            {
                ["email"] = new Dictionary<string, object>
                {
                    ["host"] = "smtp.example.com",
                    ["port"] = 587,
                    ["username"] = "user@example.com",
                    ["password"] = "password123"
                },
                ["sms"] = new Dictionary<string, object>
                {
                    ["api_key"] = "your_api_key_here",
                    ["sender_id"] = "YourApp"
                },
                ["push"] = new Dictionary<string, object>
                {
                    ["app_id"] = "your_app_id",
                    ["api_key"] = "your_push_api_key"
                }
            };
        }

        public static NotificationConfigSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new NotificationConfigSingleton();
                        }
                    }
                }
                return _instance;
            }
        }

        public Dictionary<string, object> GetConfig(string type)
        {
            return _config.ContainsKey(type) ? _config[type] : null;
        }

        public void SetConfig(string type, Dictionary<string, object> config)
        {
            _config[type] = config;
        }
    }
}
