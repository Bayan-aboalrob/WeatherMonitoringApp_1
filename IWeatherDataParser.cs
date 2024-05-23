using System;
namespace WeatherMonitoringApp
{
    internal interface IWeatherDataParser
    {
        WeatherData DataParse(string inputData);
    }
}
