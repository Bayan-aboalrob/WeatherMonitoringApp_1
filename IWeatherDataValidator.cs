using System;
namespace WeatherMonitoringApp
{
    internal interface IWeatherDataValidator
    {
        void ValidateLocation(string location);
        void ValidateTemperature(double temperature);
        void ValidateHumidity(double humidity);
    }
}
