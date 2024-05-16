using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringApp
{
    public class ConfigurationLoader
    {
        public static Dictionary<string, BotConfiguration> LoadConfigurations(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
                throw new ArgumentException("File path cannot be null or empty.", nameof(filePath));

            if (!File.Exists(filePath))
                throw new FileNotFoundException("Configuration file not found.", filePath);

            if (new FileInfo(filePath).Length == 0)
                throw new EmptyFileException("Configuration file is empty.", filePath);


            string jsonContent;

            try
            {
                jsonContent = File.ReadAllText(filePath);
            }
            catch (IOException ex)
            {
                throw new IOException("Error reading configuration file.", ex);
            }

            return JsonConvert.DeserializeObject<Dictionary<string, BotConfiguration>>(jsonContent);
        }
    }
}
