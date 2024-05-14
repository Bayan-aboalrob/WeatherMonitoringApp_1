using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringApp
{
    internal interface IWeatherDataParser
    {
        IWeatherData DataParse(string inputData);
    }
}
