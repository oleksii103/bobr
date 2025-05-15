using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_11
{
    public class AppConfig
    {
        private static readonly Lazy<AppConfig> _instance = new Lazy<AppConfig>(() => new AppConfig());
        private Dictionary<string, string> _settings;

        private AppConfig()
        {
            _settings = new Dictionary<string, string>();
        }

        public static AppConfig Instance => _instance.Value;

        public void SetSetting(string key, string value)
        {
            _settings[key] = value;
        }

        public string GetSetting(string key)
        {
            return _settings.ContainsKey(key) ? _settings[key] : null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AppConfig config = AppConfig.Instance;
            config.SetSetting("Theme", "Dark");
            config.SetSetting("Language", "English");

            Console.WriteLine("Theme: " + config.GetSetting("Theme"));
            Console.WriteLine("Language: " + config.GetSetting("Language"));

            AppConfig anotherConfig = AppConfig.Instance;
            anotherConfig.SetSetting("Theme", "Light");

            Console.WriteLine("Updated Theme: " + config.GetSetting("Theme"));
        }
    }
}
