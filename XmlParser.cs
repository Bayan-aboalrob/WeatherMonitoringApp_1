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
        public WeatherData DataParse(string inputData)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(inputData);

            XmlNode locationNode = xmlDoc.SelectSingleNode("/WeatherData/Location");
            XmlNode temperatureNode = xmlDoc.SelectSingleNode("/WeatherData/Temperature");
            XmlNode humidityNode = xmlDoc.SelectSingleNode("/WeatherData/Humidity");

            string location = locationNode?.InnerText;
            double temperature = ParseDouble(temperatureNode?.InnerText);
            double humidity = ParseDouble(humidityNode?.InnerText);

            return new WeatherData(location, temperature, humidity);
        }

        private double ParseDouble(string value)
        {
            double result;
            double.TryParse(value, out result);
            return result;
        }
    }
}
