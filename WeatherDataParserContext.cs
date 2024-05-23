using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringApp
{
    internal class WeatherDataParserContext
    {
        private IWeatherDataParser _parser;
        public WeatherDataParserContext(string inputData)
        {
            var parserFactory = new WeatherDataParserFactory();
            _parser = parserFactory.CreateParser(inputData);
        }

        public WeatherData ParseWeatherData(string inputData)
        {
            return _parser.DataParse(inputData);
        }
    }
}
