namespace WeatherMonitoringApp
{
    public class WeatherDataValidator : IWeatherDataValidator
    {
        private const double MinTemperature = -100.0; 
        private const double MaxTemperature = 100.0;  
        private const double MinHumidity = 0.0;       
        private const double MaxHumidity = 100.0;     

        public void ValidateLocation(string location)
        {
            if (string.IsNullOrEmpty(location))
            {
                throw new ArgumentNullException(nameof(location));
            }
        }

        public void ValidateTemperature(double temperature)
        {
            if (double.IsNaN(temperature))
            {
                throw new ArgumentException("Temperature cannot be NaN", nameof(temperature));
            }

            if (temperature < MinTemperature || temperature > MaxTemperature)
            {
                throw new ArgumentOutOfRangeException(nameof(temperature), $"Temperature must be between {MinTemperature} and {MaxTemperature} Celsius");
            }
        }

        public void ValidateHumidity(double humidity)
        {
            if (double.IsNaN(humidity))
            {
                throw new ArgumentException("Humidity cannot be NaN", nameof(humidity));
            }

            if (humidity < MinHumidity || humidity > MaxHumidity)
            {
                throw new ArgumentOutOfRangeException(nameof(humidity), $"Humidity must be between {MinHumidity} and {MaxHumidity} %");
            }
        }
    }
}
