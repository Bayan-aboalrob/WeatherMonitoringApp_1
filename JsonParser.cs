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
        public WeatherData DataParse(string inputData)
        {
            var jsonObject = JObject.Parse(inputData);

            return new WeatherData
            (
               (string)jsonObject["Location"],
               (double)jsonObject["Temperature"],
                (double)jsonObject["Humidity"]
            );
        }
    }
}
