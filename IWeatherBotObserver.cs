using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringApp
{
    public interface IWeatherBotObserver
    {
        public void Update(WeatherData weatherData);
    }
}
