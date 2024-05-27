namespace WeatherMonitoringApp
{
    internal class WeatherStation : IWeatherSubject
    {
        private List<IWeatherBotObserver> _observers = new List<IWeatherBotObserver>();
        private WeatherData _WeatherData { get; set; }

        public WeatherStation(List<IWeatherBotObserver> observers, WeatherData weatherData)
        {
            this._observers = observers;
            _WeatherData = null;

        }
        public void SetWeatherData(WeatherData newWeatherData)
        {
            // Update weather data and notify observers if it has changed
            if (_WeatherData == null || !_WeatherData.Equals(newWeatherData))
            {
                _WeatherData = newWeatherData;
                NotifyObservers();
            }
        }
        public void AddObserver(IWeatherBotObserver observer)
        {
            _observers.Add(observer);
        }
        public void RemoveObserver(IWeatherBotObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            if (_WeatherData != null)
            {
                foreach (var observer in _observers)
                {
                    observer.Update(_WeatherData);
                }
            }
        }
    }
}
