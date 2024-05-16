using System;
namespace WeatherMonitoringApp
{
    public class BotConfiguration
    {
        public bool Enabled { get; set; }
        public int Threshold { get; set; }
        public string Message { get; set; }
    }
}
