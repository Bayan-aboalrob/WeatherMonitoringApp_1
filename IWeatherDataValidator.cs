using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringApp
{
    internal interface IWeatherDataValidator
    {
        void ValidateLocation(string location);
        void ValidateTemperature(double temperature);
        void ValidateHumidity(double humidity);
    }
}
