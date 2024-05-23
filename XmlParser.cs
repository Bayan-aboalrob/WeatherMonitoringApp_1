using System.Xml;
namespace WeatherMonitoringApp
{
    internal class XmlParser : IWeatherDataParser
    {
        public WeatherData DataParse(string inputData)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(inputData);

            var locationNode = xmlDoc.SelectSingleNode("/WeatherData/Location");
            var temperatureNode = xmlDoc.SelectSingleNode("/WeatherData/Temperature");
            var humidityNode = xmlDoc.SelectSingleNode("/WeatherData/Humidity");

            var location = locationNode?.InnerText;
            var temperature = ParseDouble(temperatureNode?.InnerText);
            var humidity = ParseDouble(humidityNode?.InnerText);

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
