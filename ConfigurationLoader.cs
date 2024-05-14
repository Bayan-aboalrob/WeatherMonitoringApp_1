using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringApp
{
    public static class ConfigurationLoader
    {
        public static Dictionary<string, BotConfiguration> LoadConfigurations(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Configuration file not found.", filePath);

            string jsonContent = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Dictionary<string, BotConfiguration>>(jsonContent);
        }
    }
}
