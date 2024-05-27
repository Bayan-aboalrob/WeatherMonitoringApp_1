using Newtonsoft.Json.Linq;
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
