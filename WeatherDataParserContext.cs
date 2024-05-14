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
            IWeatherDataParserFactory parserFactory = new WeatherDataParserFactory();
            _parser = parserFactory.CreateParser(inputData);
        }

        public IWeatherData ParseWeatherData(string inputData)
        {
            return _parser.DataParse(inputData);
        }
    }
}
