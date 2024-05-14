using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringApp
{
    public class RainBot : IWeatherBotObserver
    {
        private readonly int humidityThreshold;
        private readonly string message;

        public RainBot(int humidityThreshold, string message)
        {
            this.humidityThreshold = humidityThreshold;
            this.message = message;
        }

        public void Update(IWeatherData weatherData)
        {
            if (weatherData.Humidity > humidityThreshold)
            {
                Console.WriteLine("RainBot activated!");
                Console.WriteLine($"RainBot: {message}");
            }
        }
    }
}
