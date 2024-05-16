using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringApp
{
    public class WeatherData
    {
        private WeatherDataValidator validator;

        public string Location { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public WeatherDataValidator Validator { get; set; }
        public WeatherData(string location, double temperature, double humidity)
        {
            this.Validator = new WeatherDataValidator();
            Validator.ValidateLocation(location);
            Validator.ValidateTemperature(temperature);
            Validator.ValidateHumidity(humidity);

            Location = location;
            Temperature = temperature;
            Humidity = humidity;


        }
    }
}
