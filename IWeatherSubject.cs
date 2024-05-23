using System;
namespace WeatherMonitoringApp
{
    internal interface IWeatherSubject
    {
        void AddObserver(IWeatherBotObserver observer);
        void RemoveObserver(IWeatherBotObserver observer);
        void NotifyObservers();
        void SetWeatherData(WeatherData DataParsed);

    }
}
