using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringApp
{
    internal class WeatherStation : IWeatherSubject
    {
        private List<IWeatherBotObserver> observers = new List<IWeatherBotObserver>();
        private IWeatherData WeatherData { get; set; }

        public WeatherStation(List<IWeatherBotObserver> observers, IWeatherData weatherData)
        {
            this.observers = observers;
            WeatherData = null;

        }
        public void SetWeatherData(IWeatherData newWeatherData)
        {
            // Update weather data and notify observers if it has changed
            if (WeatherData == null || !WeatherData.Equals(newWeatherData))
            {
                WeatherData = newWeatherData;
                NotifyObservers();
            }
        }
        public void AddObserver(IWeatherBotObserver observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(IWeatherBotObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            if (WeatherData != null)
            {
                foreach (var observer in observers)
                {
                    observer.Update(WeatherData);
                }
            }
        }
    }
}
