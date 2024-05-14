using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringApp
{
    internal interface IWeatherSubject
    {
        void AddObserver(IWeatherBotObserver observer);
        void RemoveObserver(IWeatherBotObserver observer);
        void NotifyObservers();
        void SetWeatherData(IWeatherData xmlDataParsed);
    }
}
