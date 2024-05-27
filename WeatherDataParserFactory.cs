using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Xml;

namespace WeatherMonitoringApp
{
    internal class WeatherDataParserFactory : IWeatherDataParserFactory
    {
        public IWeatherDataParser CreateParser(string inputData)
        {
            if (IsJSON(inputData))
                return new JsonParser();
            else if (IsXML(inputData))
                return new XmlParser();
            else
                throw new ArgumentException("Invalid input format.");
        }
        private bool IsJSON(string inputData)
        {
            try
            {
                JToken.Parse(inputData);
                return true;
            }
            catch (JsonReaderException)
            {
                return false;
            }
        }

        private bool IsXML(string inputData)
        {
            try
            {
                var xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(inputData);
                return true;
            }
            catch (XmlException)
            {
                return false;
            }
        }
    }
}