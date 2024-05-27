using System;
namespace WeatherMonitoringApp
{
    internal interface IWeatherDataParserFactory
    {
        IWeatherDataParser CreateParser(string inputData);
    }
}
