using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringApp
{
    public class SnowBot : IWeatherBotObserver
    {
        private readonly int temperatureThreshold;
        private readonly string message;

        public SnowBot(int temperatureThreshold, string message)
        {
            this.temperatureThreshold = temperatureThreshold;
            this.message = message;
        }

        public void Update(WeatherData weatherData)
        {
            if (weatherData.Temperature < temperatureThreshold)
            {
                Console.WriteLine("SnowBot activated!");
                Console.WriteLine($"SnowBot: {message}");
            }
        }
    }
}
