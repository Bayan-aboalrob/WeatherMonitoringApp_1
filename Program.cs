namespace WeatherMonitoringApp
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Weather Monitoring and Reporting System");

            // Loading bot configurations from a JSON file
            var configFilePath = @"C:\Users\HP\Desktop\University Files\BayanAboalrob.ComputerSystemEngineering\Trainings\FTS ASP.NET\Projects_1\WeatherMonitoringApp\botConfigurations.json";
            Dictionary<string, BotConfiguration> botConfigurations = ConfigurationLoader.LoadConfigurations(configFilePath);

            // Creating weather bots based on loaded configurations
            List<IWeatherBotObserver> bots = new List<IWeatherBotObserver>();

            foreach (var kvp in botConfigurations)
            {
                string botType = kvp.Key;
                BotConfiguration config = kvp.Value;

                if (!config.Enabled)
                    continue;
                switch (botType)
                    {
                        case "RainBot":
                            bots.Add(new RainBot(config.Threshold, config.Message));
                            break;
                        case "SunBot":
                            bots.Add(new SunBot(config.Threshold, config.Message));
                            break;
                        case "SnowBot":
                            bots.Add(new SnowBot(config.Threshold, config.Message));
                            break;
                        default:
                            Console.WriteLine($"Unknown bot type: {botType}");
                            break;
                    }
            }

            IWeatherSubject weatherStation = new WeatherStation(bots, null);


            SimulateWeatherUpdate(weatherStation);

            Console.WriteLine("Weather monitoring and reporting complete.");
        }

        private static void SimulateWeatherUpdate(IWeatherSubject weatherStation)
        {

            string jsonData = "{\"Location\": \"City Name\", \"Temperature\": 32, \"Humidity\": 70}";
            string xmlData = "<WeatherData><Location>City Name</Location><Temperature>32</Temperature><Humidity>70</Humidity></WeatherData>";


            IWeatherDataParserFactory parserFactory = new WeatherDataParserFactory();
            IWeatherDataParser jsonParser = parserFactory.CreateParser(jsonData);
            IWeatherDataParser xmlParser = parserFactory.CreateParser(xmlData);


            WeatherData jsonDataParsed = jsonParser.DataParse(jsonData);
            weatherStation.SetWeatherData(jsonDataParsed);


            WeatherData xmlDataParsed = xmlParser.DataParse(xmlData);
            weatherStation.SetWeatherData(xmlDataParsed);
        }
    }
}
