using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringApp
{
    public class BotConfiguration
    {
        public bool Enabled { get; set; }
        public int Threshold { get; set; }
        public string Message { get; set; }
    }
}
