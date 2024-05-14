using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringApp
{
    public interface IWeatherData
    {
        string Location { get; set; }
        double Temperature { get; set; }
        double Humidity { get; set; }
    }
}
