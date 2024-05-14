using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WeatherMonitoringApp
{
    internal class JsonParser : IWeatherDataParser
    {
        public IWeatherData DataParse(string inputData)
        {
            JObject jsonObject = JObject.Parse(inputData);

            return new WeatherData
            {
                Location = (string)jsonObject["Location"],
                Temperature = (double)jsonObject["Temperature"],
                Humidity = (double)jsonObject["Humidity"]
            };
        }
    }
}
