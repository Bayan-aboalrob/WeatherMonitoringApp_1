using System;
namespace WeatherMonitoringApp
{
    public interface IWeatherBotObserver
    {
        public void Update(WeatherData weatherData);
    }
}
