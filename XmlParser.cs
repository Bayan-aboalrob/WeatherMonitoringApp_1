using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WeatherMonitoringApp
{
    internal class XmlParser : IWeatherDataParser
    {
        public IWeatherData DataParse(string inputData)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(inputData);

            XmlNode locationNode = xmlDoc.SelectSingleNode("/WeatherData/Location");
            XmlNode temperatureNode = xmlDoc.SelectSingleNode("/WeatherData/Temperature");
            XmlNode humidityNode = xmlDoc.SelectSingleNode("/WeatherData/Humidity");

            return new WeatherData
            {
                Location = locationNode.InnerText,
                Temperature = double.Parse(temperatureNode.InnerText),
                Humidity = double.Parse(humidityNode.InnerText)
            };
        }
    }
}
